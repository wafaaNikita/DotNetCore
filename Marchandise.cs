using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport
{
    class Marchandise
    {
        private static int nbMarchandise;
        private int numero;
        private double poids;
        private double volume;

        public Marchandise(double p,double v)
        {
            this.numero = ++nbMarchandise;
            this.poids = p;
            this.volume = v;
        }

        public int Numero { get => numero; set => numero = value; }
        public double Poids { get => poids; set => poids = value; }
        public double Volume { get => volume; set => volume = value; }

        public override string ToString()
        {
            return "numero : " + numero + ",Poids : " + poids + "Volume: " + volume;
        }
    }
}
