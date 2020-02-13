using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carro2
{
    public partial class Form1 : Form
    {
        carro car = new carro();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnligar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(car.ligar());//chamando o metodo da classe ligar
        }

        private void btnbuzinar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(car.buzinar());//chamando o metodo da classe buzinar
        }

        private void btndesligar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(car.desligar());//chamando o metodo da classe desligar
        }

        private void bntmostrardados_Click(object sender, EventArgs e)
        {
            car.modelo = txtmodelo.Text;
            car.fabricante = txtfabricante.Text;
            car.cor = txtcor.Text;
            car.nroportas = txtnroportas.Text;
            MessageBox.Show("O modelo é: " + car.modelo +
                "\nfabricante é: " + car.fabricante + "\na cor é: " + car.cor +
                "\nnro de portas é: " + car.nroportas);
        }
    }
}
