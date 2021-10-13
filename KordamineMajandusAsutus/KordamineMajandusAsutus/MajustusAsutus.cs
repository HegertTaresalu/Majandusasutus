using System;
using System.Collections.Generic;
using System.Text;

namespace KordamineMajandusAsutus
{
    public class MajustusAsutus
    {
        protected int _kohti;
        protected decimal _hind;
        protected int _vabukohti;

        public virtual int Vabukohti
        {
            get { return _vabukohti; }
            set { _vabukohti = value; }
        }

        public virtual int Reserveeri(int külalisi)
        {
            KontrolliPiire(külalisi);
            Vabukohti -= külalisi;



            return 1;

        }

        protected void KontrolliPiire(int külalisi)
        {
            if (külalisi > Vabukohti)
            {
                throw new ArgumentOutOfRangeException(nameof(külalisi), "ei ole piisavalt kohti");
            }
            if (külalisi < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(külalisi), "ei tohi olla negatiivne arv külalisi");
            }
        }

        public MajustusAsutus(int vabukohti, int kohti)
        {
            _kohti = kohti;
            _vabukohti = vabukohti;

        }
        public override string ToString()
        {
            return ($"majutusasutus Hind: {_kohti} kohti. {Kohti},{Vabukohti}");
        }


    }
}
