using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Cifra_de_Juno
{
    class Criptografador
    {
        private string strInverter, strCesar, strCript = string.Empty;

        //Método publico de acesso ao resultado final
        public string GetResultadoFinal(int operacao)
        {
            // 0 - Criptografia, 1 - Descriptografia
            
            if(operacao < 1)
            {
                return strCript;
            }
            else
            {
                return strInverter;
            }
        }

        //Método principal, para a execução dos processos de cifragem
        public void IniciarCriptografia(string texto, string chave)
        {
            ResetarValores();

            Inverter(texto);
            CifrarCesar(strInverter, chave);
            Criptografar(strCesar, chave);
        }

        public void IniciarDescriptografia(string texto, string chave)
        {
            ResetarValores();

            Descriptografar(texto, chave);
            DescifrarCesar(strCript, chave);
            Inverter(strCesar);
        }

        //Método para inverter o texto de trás para frente
        private void Inverter(string texto)
        {
            char[] letrasInvertidas = texto.ToCharArray();

            for (int i = 0; i < texto.Length; i++)
            {
                strInverter += letrasInvertidas[(texto.Length - 1) - i];
            }
        }

        //Método usado para extrair uma chave numérica de uma chave
        private int DefinirChaveNum(string chave)
        {
            int chaveNum = 0;

            if (chave.Length % 2 == 0)
            {
                chaveNum = chave.Length / 2;
            }
            else
            {
                chaveNum = (chave.Length - 1) / 2;
            }

            return chaveNum;
        }

        //Método para a cifragem em césar
        private void CifrarCesar(string texto, string chave)
        {
            int chaveNum = DefinirChaveNum(chave);

            for(int i = 0; i < texto.Length; i++)
            {
                int ASCII = (int)texto[i];
                int ASCIIC = ASCII + chaveNum;
                strCesar += char.ConvertFromUtf32(ASCIIC);
            }
        }

        //Método para o processo inverso de césar
        private void DescifrarCesar(string texto, string chave)
        {
            int chaveNum = DefinirChaveNum(chave);

            for (int i = 0; i < texto.Length; i++)
            {
                int ASCII = (int)texto[i];
                int ASCIIC = ASCII - chaveNum;
                strCesar += char.ConvertFromUtf32(ASCIIC);
            }
        }

        //Método para criptografar com MD5 e TripleDes
        private void Criptografar(string texto, string chave)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(texto);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] chaves = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(chave));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = chaves, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transformar = tripDes.CreateEncryptor();
                    byte[] resultado = transformar.TransformFinalBlock(data, 0, data.Length);
                    strCript = Convert.ToBase64String(resultado, 0, resultado.Length);
                }
            }
        }

        private void Descriptografar(string texto, string chave)
        {
            try
            {
                byte[] data = Convert.FromBase64String(texto);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] chaves = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(chave));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = chaves, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        try
                        {
                            ICryptoTransform transformar = tripDes.CreateDecryptor();
                            byte[] resultado = transformar.TransformFinalBlock(data, 0, data.Length);
                            strCript = UTF8Encoding.UTF8.GetString(resultado);
                        }
                        catch (System.Exception)
                        {
                            //throw new Exception("Some message");
                            //MessageBox.Show(ex.Message);
                            MessageBox.Show("A mensagem e a chave são incompatíveis entre si!", "Erro!");
                        }
                    }
                }
            }
            catch (System.FormatException)
            {
                //MessageBox.Show(x.Message);
                MessageBox.Show("A mensagem e a chave são incompatíveis entre si!", "Erro!");
            }
        }

        public void ResetarValores()
        {
            strInverter = string.Empty;
            strCesar = string.Empty;
            strCript = string.Empty;
        }
    }
}