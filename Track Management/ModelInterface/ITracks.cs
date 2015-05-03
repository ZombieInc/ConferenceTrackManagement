using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackManagement.ModelInterface
{
    public interface ITracks
    {
        ITracks[] Tracks { get; set; }

         int MaxDuration
        {
            get;
            set;
        }


         DateTime StartTime
        {
            get;
            set;
        }
        

        /// <summary>
        /// Get trackId
        /// </summary>
        /// <returns></returns>
        int GetTrackId();

        /// <summary>
        /// get sessionsfor current track
        /// </summary>
        /// <returns></returns>
        List<ISessions> GetSessions();


        /// <summary>
        /// Get TimeLine for Current track
        /// </summary>
        /// <returns></returns>
        string GetFormattedTimeLine();


        /// <summary>
        /// Add session to Track
        /// </summary>
        /// <param name="session"></param>
        void AddSession(ISessions session);
    }
}
