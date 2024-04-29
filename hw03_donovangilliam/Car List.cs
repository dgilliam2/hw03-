using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw03_donovangilliam
{
    //public class to access list and associated functions across multiple forms
    public static class CarList
    {
        //public list
        public static List<CarInfo> CarInfoList = new List<CarInfo>();
        //store it in AppData
        public static string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\savedlist.txt";
        public static string fileContent;

        public static void AddToTxtFile()
        {
            fileContent = File.ReadAllText(filepath);
            using (StreamWriter sw = new StreamWriter(filepath, append: true))
            {
                foreach (CarInfo info in CarList.CarInfoList)
                {
                    if (!fileContent.Contains($"{info.vinNum}"))
                    {
                        sw.WriteLine($"{info.vinNum}");
                        sw.WriteLine($"{info.makeString}");
                        sw.WriteLine($"{info.modelString}");
                        sw.WriteLine($"{info.yearString}");
                        sw.WriteLine($"{info.colorString}");
                    }
                }
                sw.Flush();
            }
        }

        public static void LoadTxtIntoList()
        {
            //clear list to stop it from repeating when called in add form
            CarInfoList.Clear();
             //stores all lines in an array and then looks at each one for class info
            string[] fileLines = File.ReadAllLines(filepath);
            
            for (int i = 0; i < fileLines.Length; i+=5)
            {
                CarInfo info = new CarInfo()
                {
                    vinNum = fileLines[i],
                    makeString = fileLines[i + 1],
                    modelString = fileLines[i + 2],
                    yearString = fileLines[i + 3],
                    colorString = fileLines[i + 4],
                };
                CarInfoList.Add(info);
                
            }
        }
    }
}
