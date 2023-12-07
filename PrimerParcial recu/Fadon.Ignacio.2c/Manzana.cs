using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fadon.Ignacio._2c
{
    public class Manzana : Mermelada
    {
        public Manzana(Aditivos aditivos) : base(aditivos)
        {

        }
        public override string Tipo
        { get { return "Mermelada de manzana"; }}

    }
}
