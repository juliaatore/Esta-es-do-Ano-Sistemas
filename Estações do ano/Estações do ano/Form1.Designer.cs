
namespace Estações_do_ano
{
    partial class Frm_Estacoes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Estacoes));
            this.Pic_Imagem = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Grp_Estacoes = new System.Windows.Forms.GroupBox();
            this.Rad_Inverno = new System.Windows.Forms.RadioButton();
            this.Rad_Outono = new System.Windows.Forms.RadioButton();
            this.Rad_Verao = new System.Windows.Forms.RadioButton();
            this.Rad_Primavera = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).BeginInit();
            this.Grp_Estacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pic_Imagem
            // 
            this.Pic_Imagem.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Imagem.Location = new System.Drawing.Point(277, 100);
            this.Pic_Imagem.Name = "Pic_Imagem";
            this.Pic_Imagem.Size = new System.Drawing.Size(391, 251);
            this.Pic_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Imagem.TabIndex = 0;
            this.Pic_Imagem.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(305, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Grp_Estacoes
            // 
            this.Grp_Estacoes.BackColor = System.Drawing.Color.Transparent;
            this.Grp_Estacoes.Controls.Add(this.Rad_Inverno);
            this.Grp_Estacoes.Controls.Add(this.Rad_Outono);
            this.Grp_Estacoes.Controls.Add(this.Rad_Verao);
            this.Grp_Estacoes.Controls.Add(this.Rad_Primavera);
            this.Grp_Estacoes.ForeColor = System.Drawing.Color.White;
            this.Grp_Estacoes.Location = new System.Drawing.Point(138, 119);
            this.Grp_Estacoes.Name = "Grp_Estacoes";
            this.Grp_Estacoes.Size = new System.Drawing.Size(98, 189);
            this.Grp_Estacoes.TabIndex = 3;
            this.Grp_Estacoes.TabStop = false;
            this.Grp_Estacoes.Text = "Estações";
            this.Grp_Estacoes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Rad_Inverno
            // 
            this.Rad_Inverno.AutoSize = true;
            this.Rad_Inverno.ForeColor = System.Drawing.Color.White;
            this.Rad_Inverno.Location = new System.Drawing.Point(7, 138);
            this.Rad_Inverno.Name = "Rad_Inverno";
            this.Rad_Inverno.Size = new System.Drawing.Size(61, 17);
            this.Rad_Inverno.TabIndex = 3;
            this.Rad_Inverno.TabStop = true;
            this.Rad_Inverno.Text = "Inverno";
            this.Rad_Inverno.UseVisualStyleBackColor = true;
            this.Rad_Inverno.CheckedChanged += new System.EventHandler(this.Rad_Inverno_CheckedChanged);
            // 
            // Rad_Outono
            // 
            this.Rad_Outono.AutoSize = true;
            this.Rad_Outono.ForeColor = System.Drawing.Color.White;
            this.Rad_Outono.Location = new System.Drawing.Point(7, 104);
            this.Rad_Outono.Name = "Rad_Outono";
            this.Rad_Outono.Size = new System.Drawing.Size(60, 17);
            this.Rad_Outono.TabIndex = 2;
            this.Rad_Outono.TabStop = true;
            this.Rad_Outono.Text = "Outono";
            this.Rad_Outono.UseVisualStyleBackColor = true;
            this.Rad_Outono.CheckedChanged += new System.EventHandler(this.Rad_Outono_CheckedChanged);
            // 
            // Rad_Verao
            // 
            this.Rad_Verao.AutoSize = true;
            this.Rad_Verao.ForeColor = System.Drawing.Color.White;
            this.Rad_Verao.Location = new System.Drawing.Point(7, 70);
            this.Rad_Verao.Name = "Rad_Verao";
            this.Rad_Verao.Size = new System.Drawing.Size(53, 17);
            this.Rad_Verao.TabIndex = 1;
            this.Rad_Verao.TabStop = true;
            this.Rad_Verao.Text = "Verão";
            this.Rad_Verao.UseVisualStyleBackColor = true;
            this.Rad_Verao.CheckedChanged += new System.EventHandler(this.Rad_Verao_CheckedChanged);
            // 
            // Rad_Primavera
            // 
            this.Rad_Primavera.AutoSize = true;
            this.Rad_Primavera.ForeColor = System.Drawing.Color.White;
            this.Rad_Primavera.Location = new System.Drawing.Point(7, 33);
            this.Rad_Primavera.Name = "Rad_Primavera";
            this.Rad_Primavera.Size = new System.Drawing.Size(72, 17);
            this.Rad_Primavera.TabIndex = 0;
            this.Rad_Primavera.TabStop = true;
            this.Rad_Primavera.Text = "Primavera";
            this.Rad_Primavera.UseVisualStyleBackColor = true;
            this.Rad_Primavera.CheckedChanged += new System.EventHandler(this.Rad_Primavera_CheckedChanged);
            // 
            // Frm_Estacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Grp_Estacoes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pic_Imagem);
            this.Name = "Frm_Estacoes";
            this.Text = "ESTAÇÕES";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).EndInit();
            this.Grp_Estacoes.ResumeLayout(false);
            this.Grp_Estacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Imagem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox Grp_Estacoes;
        private System.Windows.Forms.RadioButton Rad_Inverno;
        private System.Windows.Forms.RadioButton Rad_Outono;
        private System.Windows.Forms.RadioButton Rad_Verao;
        private System.Windows.Forms.RadioButton Rad_Primavera;
    }
}

