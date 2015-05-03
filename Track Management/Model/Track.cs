using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackManagement.ModelInterface;

namespace TrackManagement.Model
{
    class Track:ITracks
    {
        ITracks[] _Tracks;
        int _MaxDuration;
        DateTime _StartTime;

        public ITracks[] Tracks
        {
            get
            {
                return _Tracks;
            }
            set
            {
                _Tracks = value;
            }
        }

        public int MaxDuration
        {
            get
            {
                return _MaxDuration;
            }
            set
            {
                _MaxDuration = value;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return _StartTime;
            }
            set
            {
                _StartTime = value;
            }
        }


        private int trackID;

        private List<ISessions> lstSessions;

        

        public Track(int ID)
        {
            trackID = ID;
        }

        public int GetTrackId()
        {
            return trackID;
        }


        public List<ISessions> GetSessions()
        {
            List<ISessions> lstresult = new List<ISessions>();
            if (_Tracks != null)
            {
                foreach (ITracks track in _Tracks)
                {
                    lstresult.AddRange(track.GetSessions());
                }
                
            }
            else
            {
                if (lstSessions == null)
                    lstresult = new List<ISessions>();
                else
                {
                    lstSessions.Add(GetDefaultSessions());
                    lstresult = lstSessions;

                }
            }
            return lstresult;
        }


        public void AddSession(ISessions session)
        {
            if (lstSessions == null)
                lstSessions = new List<ISessions>();
            lstSessions.Add(session);
        }

        public string GetFormattedTimeLine()
        {
            StringBuilder strResult = new StringBuilder();
            strResult.Append(String.Format("Track {0}:",trackID));

            List<ISessions> lstresult= GetSessions();
            foreach (ISessions session in lstresult)
            {
                strResult.AppendLine();
                strResult.Append(session.ToString());
            }
            return strResult.ToString();
        }


        private ISessions GetDefaultSessions()
        {
            if (trackID % 10 == 1)
            {
                Session sessionLunch = new Session(60) { Title = "Lunch" };
                sessionLunch.SetScheduledTime(new DateTime(1111, 01, 01, 12, 00, 00));
                return sessionLunch;
            }
            else
            {
                Session sessionNetwork = new Session(60) { Title = "Networking Event" };
                if (StartTime.TimeOfDay.Hours < 16)
                    StartTime = (new DateTime(1111, 01, 01, 16, 00, 00));
                sessionNetwork.SetScheduledTime(StartTime);
                return sessionNetwork;
            }
        }

    }
}
