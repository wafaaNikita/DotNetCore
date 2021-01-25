using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport
{
     class CargaisonRoutiere : Cargaison
    {
        public CargaisonRoutiere(int d):base(d)
        {
            
        }
        public override double count()
        {
            if (getVolumeToTale() < 380000)
                return 4 * distance * getVolumeToTale();
            else
                return 6 * distance * getPoidsTotal();         
        }
        public override string ToString()
        {
            return "Cargaison Routiere distance = "+ distance;
        }

    }
}
