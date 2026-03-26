namespace Agenda.UIDesktop
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
            this.LblContatoNovo = new System.Windows.Forms.Label();
            this.TxtContatoNovo = new System.Windows.Forms.TextBox();
            this.LblContatoSalvo = new System.Windows.Forms.Label();
            this.TxtContatoSalvo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblContatoNovo
            // 
            this.LblContatoNovo.AutoSize = true;
            this.LblContatoNovo.Location = new System.Drawing.Point(45, 34);
            this.LblContatoNovo.Name = "LblContatoNovo";
            this.LblContatoNovo.Size = new System.Drawing.Size(106, 20);
            this.LblContatoNovo.TabIndex = 0;
            this.LblContatoNovo.Text = "Contato Novo";
            // 
            // TxtContatoNovo
            // 
            this.TxtContatoNovo.Location = new System.Drawing.Point(157, 34);
            this.TxtContatoNovo.Name = "TxtContatoNovo";
            this.TxtContatoNovo.Size = new System.Drawing.Size(257, 26);
            this.TxtContatoNovo.TabIndex = 1;
            // 
            // LblContatoSalvo
            // 
            this.LblContatoSalvo.AutoSize = true;
            this.LblContatoSalvo.Location = new System.Drawing.Point(45, 86);
            this.LblContatoSalvo.Name = "LblContatoSalvo";
            this.LblContatoSalvo.Size = new System.Drawing.Size(106, 20);
            this.LblContatoSalvo.TabIndex = 2;
            this.LblContatoSalvo.Text = "Contato salvo";
            // 
            // TxtContatoSalvo
            // 
            this.TxtContatoSalvo.Location = new System.Drawing.Point(157, 86);
            this.TxtContatoSalvo.Name = "TxtContatoSalvo";
            this.TxtContatoSalvo.Size = new System.Drawing.Size(257, 26);
            this.TxtContatoSalvo.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(49, 137);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 28);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.TxtContatoSalvo);
            this.Controls.Add(this.LblContatoSalvo);
            this.Controls.Add(this.TxtContatoNovo);
            this.Controls.Add(this.LblContatoNovo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblContatoNovo;
        private System.Windows.Forms.TextBox TxtContatoNovo;
        private System.Windows.Forms.Label LblContatoSalvo;
        private System.Windows.Forms.TextBox TxtContatoSalvo;
        private System.Windows.Forms.Button btnSalvar;
    }
}

