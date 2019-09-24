using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuPrimeiroApp
{
    public partial class Form1 : Form
    {
        Moto Moto;
        public Form1()
        {
            InitializeComponent();
            Moto = new Moto();
        }
     
        private void Ligar_Click(object sender, EventArgs e)
        {
            string retorno = Moto.Ligar();
            MessageBox.Show(retorno);
        }
        
        private void Desligar_Click(object sender, EventArgs e)
        {
            string retorno = Moto.Desligar();
            MessageBox.Show(retorno);
        }

        private void Detalhes_Click(object sender, EventArgs e)
        {
            string retorno = Moto.Detalhes();
            MessageBox.Show(retorno);
        }

        private void Evento_Click(object sender, EventArgs e)
        {
            var valor1 = 50;
            var valor2 = 5;

            var resultado = valor1 / valor2;

            MessageBox.Show(resultado.ToString());
        }
    }
}
