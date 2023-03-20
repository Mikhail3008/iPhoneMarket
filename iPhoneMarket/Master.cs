using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPhoneMarket
{
    public class Master
    {
        private string _FIO_m;
        public string FIO_m
        {
            get => _FIO_m;
            private set => _FIO_m = value;
        }
        public Master(string fio)
        {
            _FIO_m = fio;
        }

        public override string ToString()
        {
            return FIO_m;
        }
    }
}
