using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackManagement.Model;
using TrackManagement.ModelInterface;
using TrackManagement.Utilities;

namespace TrackManagement
{
    public class ManageConference
    {
        string filepath;
        List<ISessions> Sessions;
        List<ITracks> ParentTracks;
        List<ITracks> Tracks;
        int trackCounter;

        int morningMaxduration;
        int afterMaxDuration;

        DateTime morningStartTime;
        DateTime afterStartTime;

        public ManageConference()
        {
            morningMaxduration = 180;
            morningStartTime = new DateTime(1111, 01, 01, 09, 00, 00) ;
            afterMaxDuration = 240;
            afterStartTime = new DateTime(1111, 01, 01, 13, 00, 00);
        }

        public string AddFilePath(string strpath)
        {
            if (String.IsNullOrWhiteSpace(strpath))
                return "Path is empty,Please provide valid path";
                
            strpath=strpath.Trim(new char[]{'"'});
            if (!FileHelper.ValidateFile(strpath))
                return "Invalid File,Please make sure File is present at location and with extension .txt";
            else
                filepath = strpath;
            return "OK";
        }




        public void CreateTracks()
        {
           if(String.IsNullOrWhiteSpace(filepath))
               throw new Exception("File Path not set!!");

            Sessions=FileHelper.ReadSessions(filepath);

            if(Tracks==null)
                CreateNewTrack();
            foreach (ISessions session in Sessions)
            {
                if (!Tracks.Any(q => session.GetDuration() <= q.MaxDuration))
                {
                    CreateNewTrack();
                }
                ITracks track = Tracks.Where(q => session.GetDuration() <= q.MaxDuration).First();
                track.MaxDuration-=session.GetDuration();
                session.SetScheduledTime(track.StartTime);
                track.StartTime=track.StartTime.AddMinutes(session.GetDuration());
                track.AddSession(session);
            }
        }

        
        private void CreateNewTrack()
        {
            trackCounter++;
            ITracks track = new TrackManagement.Model.Track(trackCounter);
            track.Tracks = new Track[] {new Track(track.GetTrackId()*10+1){StartTime=morningStartTime,MaxDuration=morningMaxduration},
                new Track(track.GetTrackId()*10+2){StartTime=afterStartTime,MaxDuration=afterMaxDuration}};
            if (Tracks == null)
                Tracks = new List<ITracks>();
            if (ParentTracks == null)
                ParentTracks = new List<ITracks>();
            ParentTracks.Add(track);
            Tracks.AddRange(track.Tracks);
        }

        public string[] GetScheduledTracks()
        {
            return ParentTracks.Select(q => q.GetFormattedTimeLine()).ToArray();
        }
    }
}
