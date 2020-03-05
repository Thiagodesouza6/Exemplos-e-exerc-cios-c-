namespace salario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfuncionario = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txthorasextras = new System.Windows.Forms.TextBox();
            this.txtresfuncionario = new System.Windows.Forms.TextBox();
            this.txtsalariobruto = new System.Windows.Forms.TextBox();
            this.txtsalarioliquid = new System.Windows.Forms.TextBox();
            this.txtdscto = new System.Windows.Forms.TextBox();
            this.butsair = new System.Windows.Forms.Button();
            this.butlimpar = new System.Windows.Forms.Button();
            this.butcalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poplar Std", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digitando os Dados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdscto);
            this.groupBox1.Controls.Add(this.txtsalarioliquid);
            this.groupBox1.Controls.Add(this.txtsalariobruto);
            this.groupBox1.Controls.Add(this.txtresfuncionario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESULTADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcionário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salário Bruto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salário Liquido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dscto. INSS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Funcionário:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Salário:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(255, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Horas Extras:";
            // 
            // txtfuncionario
            // 
            this.txtfuncionario.Location = new System.Drawing.Point(106, 71);
            this.txtfuncionario.Name = "txtfuncionario";
            this.txtfuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtfuncionario.TabIndex = 6;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(106, 106);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 7;
            // 
            // txthorasextras
            // 
            this.txthorasextras.Location = new System.Drawing.Point(329, 106);
            this.txthorasextras.Name = "txthorasextras";
            this.txthorasextras.Size = new System.Drawing.Size(100, 20);
            this.txthorasextras.TabIndex = 8;
            // 
            // txtresfuncionario
            // 
            this.txtresfuncionario.Location = new System.Drawing.Point(92, 11);
            this.txtresfuncionario.Name = "txtresfuncionario";
            this.txtresfuncionario.ReadOnly = true;
            this.txtresfuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtresfuncionario.TabIndex = 7;
            // 
            // txtsalariobruto
            // 
            this.txtsalariobruto.Location = new System.Drawing.Point(92, 41);
            this.txtsalariobruto.Name = "txtsalariobruto";
            this.txtsalariobruto.ReadOnly = true;
            this.txtsalariobruto.Size = new System.Drawing.Size(100, 20);
            this.txtsalariobruto.TabIndex = 8;
            // 
            // txtsalarioliquid
            // 
            this.txtsalarioliquid.Location = new System.Drawing.Point(92, 70);
            this.txtsalarioliquid.Name = "txtsalarioliquid";
            this.txtsalarioliquid.ReadOnly = true;
            this.txtsalarioliquid.Size = new System.Drawing.Size(100, 20);
            this.txtsalarioliquid.TabIndex = 9;
            // 
            // txtdscto
            // 
            this.txtdscto.Location = new System.Drawing.Point(308, 30);
            this.txtdscto.Name = "txtdscto";
            this.txtdscto.ReadOnly = true;
            this.txtdscto.Size = new System.Drawing.Size(100, 20);
            this.txtdscto.TabIndex = 10;
            // 
            // butsair
            // 
            this.butsair.Location = new System.Drawing.Point(112, 137);
            this.butsair.Name = "butsair";
            this.butsair.Size = new System.Drawing.Size(75, 23);
            this.butsair.TabIndex = 9;
            this.butsair.Text = "Sair";
            this.butsair.UseVisualStyleBackColor = true;
            this.butsair.Click += new System.EventHandler(this.butsair_Click);
            // 
            // butlimpar
            // 
            this.butlimpar.Location = new System.Drawing.Point(193, 137);
            this.butlimpar.Name = "butlimpar";
            this.butlimpar.Size = new System.Drawing.Size(75, 23);
            this.butlimpar.TabIndex = 10;
            this.butlimpar.Text = "Limpar";
            this.butlimpar.UseVisualStyleBackColor = true;
            this.butlimpar.Click += new System.EventHandler(this.butlimpar_Click);
            // 
            // butcalcular
            // 
            this.butcalcular.Location = new System.Drawing.Point(274, 137);
            this.butcalcular.Name = "butcalcular";
            this.butcalcular.Size = new System.Drawing.Size(75, 23);
            this.butcalcular.TabIndex = 11;
            this.butcalcular.Text = "Calcular";
            this.butcalcular.UseVisualStyleBackColor = true;
            this.butcalcular.Click += new System.EventHandler(this.butcalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 281);
            this.Controls.Add(this.butcalcular);
            this.Controls.Add(this.butlimpar);
            this.Controls.Add(this.butsair);
            this.Controls.Add(this.txthorasextras);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtfuncionario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdscto;
        private System.Windows.Forms.TextBox txtsalarioliquid;
        private System.Windows.Forms.TextBox txtsalariobruto;
        private System.Windows.Forms.TextBox txtresfuncionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtfuncionario;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txthorasextras;
        private System.Windows.Forms.Button butsair;
        private System.Windows.Forms.Button butlimpar;
        private System.Windows.Forms.Button butcalcular;
    }
}

