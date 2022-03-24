using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шифровщик
{
    internal class DischargeDB
    {
        public DischargeDB(string user, string operation, string Opentext, string Closedtext, int Firstkey, int Secondkey)
        {
            User = user;
            Operation = operation;
            OpenText = Opentext;
            ClosedText = Closedtext;
            FirstKey = Firstkey;
            SecondKey = Secondkey;
        }

        public string User { get; set; }
        public string Operation { get; set; }
        public string OpenText { get; set; }
        public string ClosedText { get; set; }
        public int FirstKey { get; set; }
        public int SecondKey { get; set; }
    }
}
