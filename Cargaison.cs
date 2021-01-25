using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport
{
    abstract class Cargaison
    {
        protected int distance;
        protected List<Marchandise> marchandises = new List<Marchandise>();

        public Cargaison(int d)
        {
            this.distance = d;
        }
        public void Add(Marchandise m)
        {
            marchandises.Add(m);
        }
        public void Afficher()
        {
            foreach (Marchandise m in marchandises)
            {
                Console.WriteLine(m.ToString());
            }
        }
        public Marchandise consulterMarchandise(int num)
        {
            foreach (Marchandise m in marchandises)
            {
                if (m.Numero == num) return m;
            }
            throw new Exception("Marchandise Introvable");
        }
        public double getVolumeToTale()
        {
            double somme = 0;
            foreach (Marchandise m in marchandises)
            {
                somme += m.Volume;
            }
            return somme;
        }
        public List<Marchandise> GetMarchandises()
        {
            return marchandises;
        }
        public double getPoidsTotal()
        {
            double somme = 0;
            foreach (Marchandise p in marchandises)
            {
                somme += p.Poids;
            }
            return somme;
        }
        public abstract double count();
    }
}
