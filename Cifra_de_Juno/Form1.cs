using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cifra_de_Juno
{
    public partial class TelaInicialForm : Form
    {
        private string texto, chave = string.Empty;
        private Criptografador criptografador = new Criptografador();

        public TelaInicialForm()
        {
            InitializeComponent();
        }

        //Botão de criptografar
        private void btnCript_Click(object sender, EventArgs e)
        {
            texto = txtTexto.Text;
            chave = txtChave.Text;

            criptografador.IniciarCriptografia(texto, chave);

            txtTexto.Text = string.Empty;
            txtChave.Text = string.Empty;

            txtCifra.Text = criptografador.GetResultadoFinal(0);
        }

        private void btnDescript_Click(object sender, EventArgs e)
        {
            texto = txtCifra.Text;
            chave = txtChave.Text;

            criptografador.IniciarDescriptografia(texto, chave);

            txtCifra.Text = string.Empty;
            txtChave.Text = string.Empty;

            txtTexto.Text = criptografador.GetResultadoFinal(1);
        }

        private void btnCopiarCifra_Click(object sender, EventArgs e)
        {
            if(txtCifra.Text != null)
            {
                Clipboard.SetText(txtCifra.Text);
                DefinirAviso("Cifra copiada com sucesso!");
            }
            else
            {
                DefinirAviso("Impossível copiar, o campo de texto está vazio!");
            }
        }

        private void btnCopiarTexto_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(btnCopiarTexto.Text))
            {
                Clipboard.SetText(txtTexto.Text);
                DefinirAviso("Texto copiado com sucesso!");
            }
            else
            {
                DefinirAviso("Impossível copiar, o campo de texto está vazio!");
            } 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTexto.Text = string.Empty;
            txtCifra.Text = string.Empty;
            txtChave.Text = string.Empty;
        }

        private void chkChave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChave.Checked)
            {
                txtChave.UseSystemPasswordChar = false;
            }
            else
            {
                txtChave.UseSystemPasswordChar = true;
            }
        }

        private void DefinirAviso(string aviso)
        {
            lblAvisos.Text = aviso;
        }
    }
}