using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salario
{
    public partial class Form1 : Form
    {
        calculoinss cal = new calculoinss();//instancia da classe
        public Form1()
        {
            InitializeComponent();
        }

        private void butcalcular_Click(object sender, EventArgs e)
        {
            
            cal.funcionario = (txtfuncionario.Text);
            cal.horasextras = double.Parse(txthorasextras.Text);
            cal.salario = double.Parse(txtsalario.Text);
            cal.calcularresultado();
            txtresfuncionario.Text = Convert.ToString(cal.funcionario);
            txtsalarioliquid.Text = Convert.ToString(cal.salarioliquido);
            txtsalariobruto.Text = Convert.ToString(cal.salariobruto);
            txtdscto.Text = Convert.ToString(cal.dsctoinss);
            
            
        }

        private void butsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butlimpar_Click(object sender, EventArgs e)
        {
            txtdscto.Text = "";
            txtfuncionario.Text = "";
            txthorasextras.Text = "";
            txtresfuncionario.Text = "";
            txtsalario.Text = "";
            txtsalariobruto.Text = "";
            txtsalarioliquid.Text = "";

        }
    }
}
