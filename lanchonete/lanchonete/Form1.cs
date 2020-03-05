using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lanchonete
{
    public partial class Form1 : Form
    {
        
        lanchonete lan = new lanchonete();//instancia da classe
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculartotal_Click_1(object sender, EventArgs e)
        {
            lan.lanches = int.Parse(txtlanches.Text);
            lan.refrigerantes = int.Parse(txtrefrigerante.Text);

            lan.calculatotalapagar();//chamada do metodo
            //mostra o valor total da conta na caixa de texto form
            textBox5.Text = Convert.ToString(lan.total);
        }
    }
}
