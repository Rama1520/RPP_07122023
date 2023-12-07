namespace Fadon.Ignacio._2c
{



    public abstract class Mermelada
    {

        protected bool esOrganica;
        protected Aditivos aditivo;

        public Mermelada(Aditivos aditivo)
        {
            this.aditivo = aditivo;
            this.esOrganica = false;

        }
        public Mermelada(bool esOrganica, Aditivos aditivo) : this(aditivo)
        {
            this.esOrganica = esOrganica;
        }

        public  abstract string Tipo
        {
            get ; 
        }

        public Aditivos Aditivo
        {
            get { return this.aditivo; }
        }
        public bool EsOrganica
        {
            get { return this.esOrganica; }
            set { this.esOrganica = value; }
        }

        public string GetInfo()
        {
            string retorno;
            retorno = string.Format("{0} con aditivo,{1} es organicá.", this.Tipo, this.esOrganica == true ? "Si" : "No");
            return retorno;
        }

        public static bool operator ==(Mermelada a, Mermelada b)
        {
           
            return a.Tipo == b.Tipo;
        }
       
        public static bool operator !=(Mermelada a,Mermelada b)
        {
            return !(a.Tipo == b.Tipo);
        }

        

        public enum Aditivos
        {
            Canela,
            Mascabo,
            Miel
        }
    }
}