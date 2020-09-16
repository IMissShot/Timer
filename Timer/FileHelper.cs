using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class FileHelper
    {
        public string CreateFile(string folderpath,string timer)
        {
           // string mydate = DateTime.Now.ToString("dd-MM-yyyy");
            string path = @"..\log\"+folderpath +"\\"+ timer + ".txt";

            if (!File.Exists(path)) // If file does not exists
            {
                File.Create(path).Close();
            }

            return path;
        }

        public string CreateFolder(string foldername)
        {
            string path = "";

            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            try
            {
                if (Date != foldername) 
                {
                    path = @"..\log\" + Date;
                }
                else 
                {
                    path = @"..\log\" + foldername;
                }
              

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Exception : " + ex);
            }
            return path;
        }

        public void writelog(string path,string name,string msg)
        {

            try 
            {
                string time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(time + " [" + name + "] :" + msg); // Write text to .txt file
                }
            }
            catch (Exception ex) 
            {

            }
           
            
        }
    }
}
