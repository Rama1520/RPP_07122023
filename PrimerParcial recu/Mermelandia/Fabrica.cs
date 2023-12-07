using System.Collections.Generic;

namespace Fadon.Ignacio._2c
{
    public class Fabrica
    {
        private int capacidad;
        private List<Mermelada> frascos;
        public List<Mermelada> Frascos
        {
            get { return this.frascos; }
        }
        private Fabrica()
        {
            this.frascos = new List<Mermelada>();

        }
        public Fabrica(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        public static Fabrica operator +(Fabrica fabrica, Mermelada mermelada)
        {
            if (fabrica.frascos.Count < fabrica.capacidad)
            {
                fabrica.frascos.Add(mermelada);
            }
            return fabrica;
        }

        public static Fabrica operator -(Fabrica fabrica, Mermelada mermelada)
        {
            foreach (Mermelada merme in fabrica.frascos)
            {
                if (merme == mermelada)
                {
                    fabrica.frascos.Remove(mermelada);
                }
            }
            return fabrica;
        }


    }
}
