using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curso
{
    public partial class frmlogin : Form
    {
        Aluno alu = new Aluno();
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            alu.login = txtlogin.Text;
            alu.senha = txtsenha.Text;
            label3.Text = alu.ValidarLogineSenha();
            MessageBox.Show(alu.ValidarLogineSenha());
            
        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
