using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackManagement.ModelInterface;

namespace TrackManagement.Model
{
    class Session:ISessions
    {
        private int Duration;
        public string Title;
        DateTime ScheduledTime;
        private bool Scheduled;

        public Session(int duration)
        {
            Duration = duration;
            Scheduled = false;
        }
        public Session(string title,int duration)
        {
            Title = title;
            Duration = duration;
            Scheduled = false;
        }

        
        public int GetDuration()
        {
            return Duration;
        }

        public string GetSessionName()
        {
            return Title;
        }


        public DateTime GetScheduledTime()
        {
            return ScheduledTime;
        }

        public void SetScheduledTime(DateTime dtime)
        {
            ScheduledTime =Convert.ToDateTime(dtime);
            Scheduled = false;
        }

        public void SetDuration(int duration)
        {
            Duration = duration;
        }

        public void SetSessionName(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}", new object[] {ScheduledTime.ToString("hh:mm tt"),Title});
        }
    }
}
