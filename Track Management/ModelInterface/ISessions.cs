using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackManagement.ModelInterface
{
    public interface ISessions
    {
       
        /// <summary>
        /// set duration for session
        /// </summary>
        void SetDuration(int duration);

        /// <summary>
        /// set Session name
        /// </summary>
        void SetSessionName(string title);

        /// <summary>
        /// get Duration of session
        /// </summary>
        /// <returns></returns>
        int GetDuration();

        /// <summary>
        /// get Name of session
        /// </summary>
        /// <returns></returns>
        string GetSessionName();

        /// <summary>
        /// Get scheduled Time of session;
        /// </summary>
        /// <returns></returns>
        DateTime GetScheduledTime();
        
        /// <summary>
        /// Set Scheduledtime
        /// </summary>
        /// <param name="dtime"></param>
        void SetScheduledTime(DateTime dtime);
    }
}
