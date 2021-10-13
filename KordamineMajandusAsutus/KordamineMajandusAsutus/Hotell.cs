using System;
using System.Collections.Generic;
using System.Text;

namespace KordamineMajandusAsutus
{
    public class Hotell : MajustusAsutus
    {
        private int _tubadearv;
        private int _kohtitoas;
        private int vabutube;

        public Hotell(int vabukohti, int tubadearv, int kohtitoas) : base(vabukohti, tubadearv * kohtitoas)
        {
            _tubadearv = tubadearv;
            _kohtitoas = kohtitoas;
        }

        public override int Vabukohti { get => base.Vabukohti; set => base.Vabukohti = value; }



        public int Vabutube
        {
            get => vabutube * _kohtitoas; 
            set
            {
                vabutube = (int)Math.Ceiling((double)value/_kohtitoas);
            }
        }

        public override int Reserveeri(int külalisi)
        {
            KontrolliPiire(külalisi);
            int tubevaja = (int)Math.Ceiling((double)külalisi / _kohtitoas);
            vabutube -= tubevaja;
            return tubevaja;
        }




    }
}
