namespace carro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnbuzinar = new System.Windows.Forms.Button();
            this.btndesligar = new System.Windows.Forms.Button();
            this.btnligar = new System.Windows.Forms.Button();
            this.bntmostrardados = new System.Windows.Forms.Button();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtnroportas = new System.Windows.Forms.TextBox();
            this.txtfabricante = new System.Windows.Forms.TextBox();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuzinar
            // 
            this.btnbuzinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuzinar.Location = new System.Drawing.Point(161, 231);
            this.btnbuzinar.Name = "btnbuzinar";
            this.btnbuzinar.Size = new System.Drawing.Size(114, 38);
            this.btnbuzinar.TabIndex = 5;
            this.btnbuzinar.Text = "Buzinar";
            this.btnbuzinar.UseVisualStyleBackColor = true;
            this.btnbuzinar.Click += new System.EventHandler(this.btnbuzinar_Click);
            // 
            // btndesligar
            // 
            this.btndesligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesligar.Location = new System.Drawing.Point(281, 231);
            this.btndesligar.Name = "btndesligar";
            this.btndesligar.Size = new System.Drawing.Size(114, 38);
            this.btndesligar.TabIndex = 4;
            this.btndesligar.Text = "Desligar";
            this.btndesligar.UseVisualStyleBackColor = true;
            this.btndesligar.Click += new System.EventHandler(this.btndesligar_Click);
            // 
            // btnligar
            // 
            this.btnligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnligar.Location = new System.Drawing.Point(41, 231);
            this.btnligar.Name = "btnligar";
            this.btnligar.Size = new System.Drawing.Size(114, 38);
            this.btnligar.TabIndex = 3;
            this.btnligar.Text = "Ligar";
            this.btnligar.UseVisualStyleBackColor = true;
            this.btnligar.Click += new System.EventHandler(this.btnligar_Click);
            // 
            // bntmostrardados
            // 
            this.bntmostrardados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntmostrardados.Location = new System.Drawing.Point(401, 231);
            this.bntmostrardados.Name = "bntmostrardados";
            this.bntmostrardados.Size = new System.Drawing.Size(114, 38);
            this.bntmostrardados.TabIndex = 8;
            this.bntmostrardados.Text = "Mostrar Dados";
            this.bntmostrardados.UseVisualStyleBackColor = true;
            this.bntmostrardados.Click += new System.EventHandler(this.bntmostrardados_Click);
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(161, 61);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(182, 20);
            this.txtmodelo.TabIndex = 9;
            // 
            // txtnroportas
            // 
            this.txtnroportas.Location = new System.Drawing.Point(161, 169);
            this.txtnroportas.Name = "txtnroportas";
            this.txtnroportas.Size = new System.Drawing.Size(70, 20);
            this.txtnroportas.TabIndex = 10;
            // 
            // txtfabricante
            // 
            this.txtfabricante.Location = new System.Drawing.Point(161, 99);
            this.txtfabricante.Name = "txtfabricante";
            this.txtfabricante.Size = new System.Drawing.Size(182, 20);
            this.txtfabricante.TabIndex = 10;
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(161, 134);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(182, 20);
            this.txtcor.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fabricante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nro. de Portas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::carro.Properties.Resources._008_11_985x737;
            this.pictureBox1.Location = new System.Drawing.Point(375, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 289);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.txtfabricante);
            this.Controls.Add(this.txtnroportas);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.bntmostrardados);
            this.Controls.Add(this.btnbuzinar);
            this.Controls.Add(this.btndesligar);
            this.Controls.Add(this.btnligar);
            this.Name = "Form1";
            this.Text = "Controle de Carros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuzinar;
        private System.Windows.Forms.Button btndesligar;
        private System.Windows.Forms.Button btnligar;
        private System.Windows.Forms.Button bntmostrardados;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtnroportas;
        private System.Windows.Forms.TextBox txtfabricante;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

