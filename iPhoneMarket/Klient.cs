using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPhoneMarket
{
    public class Klient
    {
        private string _FIO;
        public string FIO
        {
            get => _FIO;
            set => _FIO = value;
        }
        public Klient(string fio1)
        {
            _FIO = fio1;
        }

        public override string ToString()
        {
            return FIO;
        }

    }
}
