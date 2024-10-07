using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_1._1.Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        moto Moto;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string Marca= tbMarca.Text;
            int Modelo=Convert.ToInt32(tbModelo.Text);
            double Valor= Convert.ToDouble(tbValor.Text);
            int AñoCal= Convert.ToInt32(tbAñoCal.Text);
            double Tasa= Convert.ToDouble(tbTasa.Text);
            int VidaUtil=Convert.ToInt32(tbAñosUtiles.Text);
            int AñosUso = AñoCal - Modelo;

            Moto=new moto(Marca,Modelo, Valor);

             VerResultados ventana= new VerResultados();
            double lineal = Moto.CalcuDepLineal(AñosUso,VidaUtil);
            double anual = Moto.CalcuDepAnual(AñosUso, Tasa);

            ventana.lblResultados.Items.Add("Marca:"+Moto.marca+",Modelo:"+Moto.modelo+",Valor:$"+Moto.ValorFabricacion);
            ventana.lblResultados.Items.Add("Depreciacion Lineal:$" + lineal);
            ventana.lblResultados.Items.Add("Depreciacion Anual:$" + anual);
            ventana.ShowDialog();

        }
    }
}
