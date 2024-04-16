using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimplesEvertonDeusSupremo
{
    public partial class Form1 : Form
    {
        //método construtor
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public int testevirgula;
        enum Operacoes//enum é uma lista de coisas/opções
        { 
            soma,
            subtrai,
            multiplica,
            divide,
            nenhuma
        }

        static Operacoes UltimaOperacao = Operacoes.nenhuma;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            UltimaOperacao = Operacoes.nenhuma;
            testevirgula = 0;
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            if (UltimaOperacao == Operacoes.nenhuma)
            {
                UltimaOperacao = Operacoes.subtrai;
                testevirgula = 0;
            }
            else
            {
                FazerCalculo(UltimaOperacao);
                testevirgula = 0;
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonAdicao_Click(object sender, EventArgs e)
        {
            if (UltimaOperacao == Operacoes.nenhuma)
            {
                UltimaOperacao = Operacoes.soma;
                testevirgula = 0;
            }
            else
            { 
                FazerCalculo(UltimaOperacao);
                testevirgula = 0;
            }
            textBoxDisplay.Text += (sender as Button).Text; 
        }

        private void FazerCalculo(Operacoes ultimaOperacao)
        {
            //double é número real
            List<double> ListaDeNumeros = new List<double>();//criar uma lista vazia

            switch (UltimaOperacao)
            {
                case Operacoes.soma:
                    ListaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] + ListaDeNumeros[1]).ToString();
                    break;
                case Operacoes.subtrai:
                    ListaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] - ListaDeNumeros[1]).ToString();
                    break;
                case Operacoes.multiplica:
                    ListaDeNumeros = textBoxDisplay.Text.Split('x').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] * ListaDeNumeros[1]).ToString();
                    break;
                case Operacoes.divide:
                    try
                    {
                        ListaDeNumeros = textBoxDisplay.Text.Split('÷').Select(double.Parse).ToList();
                        textBoxDisplay.Text = (ListaDeNumeros[0] / ListaDeNumeros[1]).ToString();
                    }
                    catch(DivideByZeroException)
                    {
                        textBoxDisplay.Text = "Não é possível dividir por zero"; 
                    }
                    break;
                case Operacoes.nenhuma:
                    break;
                default:
                    break;
            }
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            //Se ultima operação for diferente de nenhuma
            if (UltimaOperacao != Operacoes.nenhuma)
            {
                FazerCalculo(UltimaOperacao);
                testevirgula = 0;
            }
            UltimaOperacao = Operacoes.nenhuma;
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            if (UltimaOperacao == Operacoes.nenhuma)
            {
                UltimaOperacao = Operacoes.multiplica;
                testevirgula = 0;
            }
            else
            {
                FazerCalculo(UltimaOperacao);
                testevirgula = 0;
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void ButtonDivisao_Click(object sender, EventArgs e)
        {
            if (UltimaOperacao == Operacoes.nenhuma)
            {
                UltimaOperacao = Operacoes.divide;
                testevirgula = 0;
            }
            else
            {
                FazerCalculo(UltimaOperacao);
                testevirgula = 0;
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }

        private void buttonSinal_Click(object sender, EventArgs e)
        {
            //Fazer a alteração de sinal
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            if (testevirgula != 1)
            {
                textBoxDisplay.Text = textBoxDisplay.Text += ",";
                testevirgula = 1;
            }
            else
            {
                return;
            }

        }

        private void buttonNumero_Click(object sender, EventArgs e)
        {
            //textBoxDisplay.Text = textBoxDisplay.Text += "0"
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {   if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
                if (textBoxDisplay.Text.EndsWith(","))
                {
                    testevirgula = 0;
                }
                else
                { 
                    return; 
                }
            }
            else
            {
                return;
            }
            
        }

        private void buttonParenteses_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "()";
        }
    }
}
