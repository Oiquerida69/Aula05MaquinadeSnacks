using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinadeCoisinhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static double saldo;
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(soma < 11)
            {
                MessageBox.Show("Você não possui o Saldo necessario para isso");
            }
            if (soma >= 11)
            {
                soma = soma - 11;
                lbl_saldo.Text = $"{soma}";
                MessageBox.Show("Compra realizada com sucesso");
            }

        }
        private static double soma;
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            saldo = double.Parse(textBox1.Text);
            //lbl_saldo.Text = $"{saldo}";)
             double Valor = double.Parse(lbl_saldo.Text);
            
            soma = saldo + Valor;
            lbl_saldo.Text = $"{soma}";

            

        }

        private void btn_Bolinho_Click(object sender, EventArgs e)
        {
            if(soma < 7)
            {
                MessageBox.Show("Você não possui o Saldo necessario para isso");
            }
            if(soma >= 7) 
            {
                soma = soma - 7;
                lbl_saldo.Text = $"{soma}";
                MessageBox.Show("Compra realizada com sucesso");
            }
        }

        private void btn_Chocolate_Click(object sender, EventArgs e)
        {
            if(soma < 9) 
            {
                MessageBox.Show("Você não possui o Saldo necessario para isso");
            }
            if(soma >= 9) 
            {
                soma = soma - 9;
                lbl_saldo.Text = $"{soma}";
                MessageBox.Show("Compra realizada com sucesso");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
