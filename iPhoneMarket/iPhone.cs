using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPhoneMarket
{
    internal class iPhone
    {
        public string _model;
        public int _imei;
        public string _sost;
        public int _summ_sk;
        public int _summ_pr;
        public int _pribil;

        public string Model
        {
            get => _model;
        }

        public int imei
        {
            get => _imei;
        }

        public string Sost
        {
            get => _sost;
        }
        public int summ_sk
        {
            get => _summ_sk;
        }
        public int summ_pr
        {
            get => _summ_pr;
        }
        public int pribil
        {
            get => _pribil;
        }
        public iPhone(string Model, int imei, string Sost, int summ_sk, int summ_pr, int pribil)
        {
            _model = Model;
            _imei = imei;
            _sost = Sost;
            _summ_sk = summ_sk;
            _summ_pr = summ_pr;
            _pribil = pribil;
        }
    }
}
