using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogicLibrary
{
    public class FileUtility
    {
        public static string FileToString(string pathFileInput)
        {
            string s = File.ReadAllText(pathFileInput);
            return s;
        }

        public static MyQueue FileToMyQueue(string pathFileInput)
        {

                FileStream f = new FileStream(pathFileInput, FileMode.Open);
                StreamReader r = new StreamReader(f);
                MyQueue DecFromFile = new MyQueue();
                string str = r.ReadLine();
                while (str != null)
                {
                    double v = Convert.ToDouble(str);
                    DecFromFile.InQueue(v);
                    str = r.ReadLine();
                }
            f.Close();
            r.Close();
                return DecFromFile;
            
        }
    }
}
