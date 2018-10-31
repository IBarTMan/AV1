namespace Jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtVitoria = new System.Windows.Forms.Label();
            this.txtDerrota = new System.Windows.Forms.Label();
            this.txtEmpate = new System.Windows.Forms.Label();
            this.imgPapel = new System.Windows.Forms.PictureBox();
            this.imgPedra = new System.Windows.Forms.PictureBox();
            this.imgTesoura = new System.Windows.Forms.PictureBox();
            this.imgAI = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPedra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTesoura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAI)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVitoria
            // 
            this.txtVitoria.AutoSize = true;
            this.txtVitoria.Location = new System.Drawing.Point(12, 9);
            this.txtVitoria.Name = "txtVitoria";
            this.txtVitoria.Size = new System.Drawing.Size(50, 13);
            this.txtVitoria.TabIndex = 0;
            this.txtVitoria.Text = "Vitorias:0";
            // 
            // txtDerrota
            // 
            this.txtDerrota.AutoSize = true;
            this.txtDerrota.Location = new System.Drawing.Point(12, 31);
            this.txtDerrota.Name = "txtDerrota";
            this.txtDerrota.Size = new System.Drawing.Size(56, 13);
            this.txtDerrota.TabIndex = 1;
            this.txtDerrota.Text = "Derrotas:0";
            // 
            // txtEmpate
            // 
            this.txtEmpate.AutoSize = true;
            this.txtEmpate.Location = new System.Drawing.Point(12, 56);
            this.txtEmpate.Name = "txtEmpate";
            this.txtEmpate.Size = new System.Drawing.Size(57, 13);
            this.txtEmpate.TabIndex = 2;
            this.txtEmpate.Text = "Empates:0";
            // 
            // imgPapel
            // 
            this.imgPapel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgPapel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPapel.Image = ((System.Drawing.Image)(resources.GetObject("imgPapel.Image")));
            this.imgPapel.Location = new System.Drawing.Point(15, 325);
            this.imgPapel.Name = "imgPapel";
            this.imgPapel.Size = new System.Drawing.Size(200, 239);
            this.imgPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPapel.TabIndex = 3;
            this.imgPapel.TabStop = false;
            this.imgPapel.Click += new System.EventHandler(this.imgPapel_Click);
            // 
            // imgPedra
            // 
            this.imgPedra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgPedra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPedra.Image = ((System.Drawing.Image)(resources.GetObject("imgPedra.Image")));
            this.imgPedra.Location = new System.Drawing.Point(248, 325);
            this.imgPedra.Name = "imgPedra";
            this.imgPedra.Size = new System.Drawing.Size(214, 239);
            this.imgPedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPedra.TabIndex = 4;
            this.imgPedra.TabStop = false;
            this.imgPedra.Click += new System.EventHandler(this.imgPedra_Click);
            // 
            // imgTesoura
            // 
            this.imgTesoura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgTesoura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgTesoura.Image = ((System.Drawing.Image)(resources.GetObject("imgTesoura.Image")));
            this.imgTesoura.Location = new System.Drawing.Point(489, 325);
            this.imgTesoura.Name = "imgTesoura";
            this.imgTesoura.Size = new System.Drawing.Size(224, 239);
            this.imgTesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTesoura.TabIndex = 5;
            this.imgTesoura.TabStop = false;
            this.imgTesoura.Click += new System.EventHandler(this.imgTesoura_Click);
            // 
            // imgAI
            // 
            this.imgAI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgAI.Location = new System.Drawing.Point(248, 9);
            this.imgAI.Margin = new System.Windows.Forms.Padding(5);
            this.imgAI.Name = "imgAI";
            this.imgAI.Size = new System.Drawing.Size(229, 247);
            this.imgAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAI.TabIndex = 6;
            this.imgAI.TabStop = false;
            this.imgAI.Click += new System.EventHandler(this.imgAI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oponente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "VS";
            // 
            // txtReset
            // 
            this.txtReset.Location = new System.Drawing.Point(15, 81);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(75, 23);
            this.txtReset.TabIndex = 9;
            this.txtReset.Text = "Resetar";
            this.txtReset.UseVisualStyleBackColor = true;
            this.txtReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 576);
            this.Controls.Add(this.txtReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgAI);
            this.Controls.Add(this.imgTesoura);
            this.Controls.Add(this.imgPedra);
            this.Controls.Add(this.imgPapel);
            this.Controls.Add(this.txtEmpate);
            this.Controls.Add(this.txtDerrota);
            this.Controls.Add(this.txtVitoria);
            this.Name = "Form1";
            this.Text = "Jan-kem-po";
            ((System.ComponentModel.ISupportInitialize)(this.imgPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPedra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTesoura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtVitoria;
        private System.Windows.Forms.Label txtDerrota;
        private System.Windows.Forms.Label txtEmpate;
        private System.Windows.Forms.PictureBox imgPapel;
        private System.Windows.Forms.PictureBox imgPedra;
        private System.Windows.Forms.PictureBox imgTesoura;
        private System.Windows.Forms.PictureBox imgAI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtReset;
    }
}

