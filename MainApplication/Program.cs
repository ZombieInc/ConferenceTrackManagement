using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using TrackManagement;
using TrackManagement.ModelInterface;

namespace MainApplication
{
    class Program
    {
        static ManageConference manageconf;
        static void Main(string[] args)
        {
            string validfile=string.Empty;
            string strfilepath=string.Empty;
            manageconf=new ManageConference();
            do
            {
                Console.WriteLine("Enter path of Text File:");
                strfilepath = Console.ReadLine();
                validfile = manageconf.AddFilePath(strfilepath);
                if (!String.Equals(validfile, "OK"))
                    Console.WriteLine(validfile);
            }
            while (!String.Equals(validfile, "OK"));

            try
            {
                manageconf.CreateTracks();
                string[] strFinalSchedule = manageconf.GetScheduledTracks();
                foreach (string strSchedule in strFinalSchedule)
                {
                    Console.WriteLine(strSchedule);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

    }
}
