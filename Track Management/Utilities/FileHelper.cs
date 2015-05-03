using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackManagement.ModelInterface;

namespace TrackManagement.Utilities
{
    public static class FileHelper
    {

        public static bool ValidateFile(string path)
        {
            bool result = false;
            if (!String.IsNullOrWhiteSpace(path))
            {
                
                try
                {
                    result = File.Exists(path) && path.EndsWith("txt");
                }
                catch (Exception ex)
                {
                    //logging
                }
            }
            return result;
        }

        public static List<ISessions> ReadSessions(string strpath)
        {
            if (String.IsNullOrWhiteSpace(strpath))
                return null;

            List<ISessions> result = new List<ISessions>();
            try
            {
                string[] data= File.ReadAllLines(strpath);
                if (data != null)
                {
                    foreach(string strSession in data)
                    {
                        var obj=ParsingHelper.GetSession(strSession);
                        if(obj!=null)
                        result.Add(obj);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
            return result;
        }

    }
}
