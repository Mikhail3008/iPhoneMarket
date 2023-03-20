using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPhoneMarket
{
    public class Zakaz
    {
        private string _model;
        private int _imei;
        private string _PrOb;
        private Klient _klient;
        private string _PhoneNumber;
        private Master _master;
        private string _komment;
        public string Model
        {
            get => _model;
        }
        public int Imei
        {
            get => _imei;
        }
        public string PrOb
        {
            get => _PrOb;
        }
        public Klient Klient
        {
            get => _klient;
        }
        public string PhoneNumber
        {
            get => _PhoneNumber;
        }
        public Master Master
        {
            get => _master;
        }
        public string Komment
        { get => _komment;}
        public Zakaz(string model, int imei, string prob, Klient klient, string phonenumber, Master master, string komm)
        {
            _model = model;
            _imei = imei;
            _PrOb = prob;
            _klient = klient;
            _PhoneNumber = phonenumber;
            _master = master;
            _komment = komm;
        }
    }
}
