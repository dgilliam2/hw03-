using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hw03_donovangilliam
{
    public class CarInfo
    {
        public string vinNum { get; set; }
        public string makeString { get; set; }
        public string modelString { get; set; }
        public string yearString { get; set; }
        public string colorString { get; set; }

        public CarInfo()
        {
        }
    }
}
