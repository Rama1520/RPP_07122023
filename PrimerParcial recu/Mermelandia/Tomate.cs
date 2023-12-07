using System.Text;
using static Fadon.Ignacio._2c.Mermelada;

namespace Fadon.Ignacio._2c
{
    public class Tomate : Mermelada
    {
        public string receta;

        public string Receta
        {
            get 
            { 
                if(this.receta == "")
                {
                    this.receta = "Indefinida";
                }
                
                return this.receta; 
            }
            set { this.receta = value; }
        }
        public Tomate(Aditivos aditivos) : base(Aditivos.Mascabo)
        {
            
        }
        public override string Tipo
        {
            get { return "Mermelada de tomate"; }
        }
        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Receta:");
            sb.AppendLine(Receta);

            return sb.ToString();   

        }
    }
}
