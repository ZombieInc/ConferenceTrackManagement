using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackManagement.Model;
using TrackManagement.ModelInterface;

namespace TrackManagement.Utilities
{
    public static class ParsingHelper
    {
        public static ISessions GetSession(string sessioninfo)
        {
            if(String.IsNullOrWhiteSpace(sessioninfo))
                return null;

            int duration;
            sessioninfo=sessioninfo.Trim();
            if(sessioninfo.Substring(sessioninfo.LastIndexOf(" ")+1).Contains("lightning"))
                duration=5;
            else
            {
                duration=Convert.ToInt32(sessioninfo.Substring(sessioninfo.LastIndexOf(" ")+1).Replace("min",""));
            }
            ISessions session = new Session(sessioninfo, duration);
            return session;
        }
    }

}
