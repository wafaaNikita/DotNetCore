using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport
{
    class CargaisonAereinne : Cargaison
    {
        public CargaisonAereinne(int d) : base(d)
        {

        }
        public override double count()
        {
            if (getVolumeToTale() < 380000)
                return 10 * distance * getVolumeToTale();
            else
                return 12 * distance * getPoidsTotal();
        }
        public override string ToString()
        {
            return "Cargaison Aereinne distance = " + distance;
        }
    }
}
