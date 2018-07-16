namespace Cifra_de_Juno
{
    partial class TelaInicialForm
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
            this.lblTextoOriginal = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtCifra = new System.Windows.Forms.TextBox();
            this.lblTextoCript = new System.Windows.Forms.Label();
            this.lblChave = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.chkChave = new System.Windows.Forms.CheckBox();
            this.btnCript = new System.Windows.Forms.Button();
            this.btnDescript = new System.Windows.Forms.Button();
            this.btnCopiarCifra = new System.Windows.Forms.Button();
            this.btnCopiarTexto = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblAvisos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTextoOriginal
            // 
            this.lblTextoOriginal.AutoSize = true;
            this.lblTextoOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoOriginal.Location = new System.Drawing.Point(39, 31);
            this.lblTextoOriginal.Name = "lblTextoOriginal";
            this.lblTextoOriginal.Size = new System.Drawing.Size(198, 24);
            this.lblTextoOriginal.TabIndex = 0;
            this.lblTextoOriginal.Text = "Texto para criptografar";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(44, 59);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(312, 149);
            this.txtTexto.TabIndex = 1;
            // 
            // txtCifra
            // 
            this.txtCifra.Location = new System.Drawing.Point(449, 59);
            this.txtCifra.Multiline = true;
            this.txtCifra.Name = "txtCifra";
            this.txtCifra.Size = new System.Drawing.Size(312, 149);
            this.txtCifra.TabIndex = 3;
            // 
            // lblTextoCript
            // 
            this.lblTextoCript.AutoSize = true;
            this.lblTextoCript.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoCript.Location = new System.Drawing.Point(444, 31);
            this.lblTextoCript.Name = "lblTextoCript";
            this.lblTextoCript.Size = new System.Drawing.Size(229, 24);
            this.lblTextoCript.TabIndex = 2;
            this.lblTextoCript.Text = "Texto para descriptografar";
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChave.Location = new System.Drawing.Point(43, 231);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(69, 24);
            this.lblChave.TabIndex = 4;
            this.lblChave.Text = "Chave:";
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(118, 236);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(525, 20);
            this.txtChave.TabIndex = 5;
            this.txtChave.UseSystemPasswordChar = true;
            // 
            // chkChave
            // 
            this.chkChave.AutoSize = true;
            this.chkChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChave.Location = new System.Drawing.Point(649, 236);
            this.chkChave.Name = "chkChave";
            this.chkChave.Size = new System.Drawing.Size(112, 20);
            this.chkChave.TabIndex = 6;
            this.chkChave.Text = "Mostrar chave";
            this.chkChave.UseVisualStyleBackColor = true;
            this.chkChave.CheckedChanged += new System.EventHandler(this.chkChave_CheckedChanged);
            // 
            // btnCript
            // 
            this.btnCript.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCript.Location = new System.Drawing.Point(43, 282);
            this.btnCript.Name = "btnCript";
            this.btnCript.Size = new System.Drawing.Size(356, 29);
            this.btnCript.TabIndex = 7;
            this.btnCript.Text = "Criptografar texto";
            this.btnCript.UseVisualStyleBackColor = true;
            this.btnCript.Click += new System.EventHandler(this.btnCript_Click);
            // 
            // btnDescript
            // 
            this.btnDescript.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescript.Location = new System.Drawing.Point(405, 282);
            this.btnDescript.Name = "btnDescript";
            this.btnDescript.Size = new System.Drawing.Size(356, 29);
            this.btnDescript.TabIndex = 8;
            this.btnDescript.Text = "Descriptografar texto";
            this.btnDescript.UseVisualStyleBackColor = true;
            this.btnDescript.Click += new System.EventHandler(this.btnDescript_Click);
            // 
            // btnCopiarCifra
            // 
            this.btnCopiarCifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiarCifra.Location = new System.Drawing.Point(405, 317);
            this.btnCopiarCifra.Name = "btnCopiarCifra";
            this.btnCopiarCifra.Size = new System.Drawing.Size(357, 29);
            this.btnCopiarCifra.TabIndex = 9;
            this.btnCopiarCifra.Text = "Copiar texto cifrado";
            this.btnCopiarCifra.UseVisualStyleBackColor = true;
            this.btnCopiarCifra.Click += new System.EventHandler(this.btnCopiarCifra_Click);
            // 
            // btnCopiarTexto
            // 
            this.btnCopiarTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiarTexto.Location = new System.Drawing.Point(43, 317);
            this.btnCopiarTexto.Name = "btnCopiarTexto";
            this.btnCopiarTexto.Size = new System.Drawing.Size(356, 29);
            this.btnCopiarTexto.TabIndex = 10;
            this.btnCopiarTexto.Text = "Copiar texto";
            this.btnCopiarTexto.UseVisualStyleBackColor = true;
            this.btnCopiarTexto.Click += new System.EventHandler(this.btnCopiarTexto_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(44, 364);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(717, 29);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar todos os campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblAvisos
            // 
            this.lblAvisos.AutoSize = true;
            this.lblAvisos.Location = new System.Drawing.Point(12, 402);
            this.lblAvisos.Name = "lblAvisos";
            this.lblAvisos.Size = new System.Drawing.Size(0, 13);
            this.lblAvisos.TabIndex = 12;
            // 
            // TelaInicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.lblAvisos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCopiarTexto);
            this.Controls.Add(this.btnCopiarCifra);
            this.Controls.Add(this.btnDescript);
            this.Controls.Add(this.btnCript);
            this.Controls.Add(this.chkChave);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.lblChave);
            this.Controls.Add(this.txtCifra);
            this.Controls.Add(this.lblTextoCript);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblTextoOriginal);
            this.Name = "TelaInicialForm";
            this.Text = "Cifra de Juno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoOriginal;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtCifra;
        private System.Windows.Forms.Label lblTextoCript;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.CheckBox chkChave;
        private System.Windows.Forms.Button btnCript;
        private System.Windows.Forms.Button btnDescript;
        private System.Windows.Forms.Button btnCopiarCifra;
        private System.Windows.Forms.Button btnCopiarTexto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblAvisos;
    }
}

