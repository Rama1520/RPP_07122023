using Fadon.Ignacio._2c;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mermelandia
{
    public partial class Form1 : Form
    {

        Fabrica mermeladas;

        public Form1()
        {

            mermeladas = new Fabrica(10);
            Mermelada mermelada = new Manzana(Mermelada.Aditivos.Mascabo);
            mermeladas = mermeladas + mermelada;
            InitializeComponent();
        }
            
        void Refrescar()
        {
            listBox1.Items.Clear();
            StringBuilder sb = new StringBuilder();

            foreach (Mermelada item in mermeladas.Frascos) 
            { 
                sb.Append( item.GetInfo());
            }

            listBox1.Items.Add(sb.ToString());

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mermelada nuevaMermelada = null;

            switch (comboBox1.Text)
            {
                case "Pera":
                    nuevaMermelada = new Pera(Mermelada.Aditivos.Canela);
                    break;
                case "Manzana":
                    nuevaMermelada = new Manzana(Mermelada.Aditivos.Mascabo);

                    break;
                case "Tomate":
                    nuevaMermelada = new Tomate(Mermelada.Aditivos.Mascabo);

                    break;
                default: break;
            }

            foreach (Mermelada item in mermeladas.Frascos)
            {
                if (ite == null)
            }

        }

        private void btnfabricar_Click(object sender, EventArgs e)
        {
            Mermelada nuevaMermelada = null;

            

            switch(comboBox1.Text)
            {
                case "Pera":
                    nuevaMermelada = new Pera(Mermelada.Aditivos.Canela);
                    break;
                case "Manzana":
                    nuevaMermelada = new Manzana(Mermelada.Aditivos.Mascabo);

                    break;
                case "Tomate":
                    nuevaMermelada = new Tomate(Mermelada.Aditivos.Mascabo);

                    break;
                default: break;
            }

            if(nuevaMermelada != null)
            {
                mermeladas = mermeladas + nuevaMermelada;
                Refrescar();
            }


        }
    }
}
