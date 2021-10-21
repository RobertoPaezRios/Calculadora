using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primero; 
        double segundo;
        string operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "0";
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "8";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();

            

        }
        public double Sumar(double num1, double num2)
        {
            double resultado;
            resultado = num1 + num2;
            return resultado;
        }
        public double Restar(double num1, double num2)
        {
            double resultado;
            resultado = num1 - num2;
            return resultado;
        }
        public double Multiplicar(double num1, double num2)
        {
            double resultado;
            resultado = num1 * num2;
            return resultado;
        }
        public double Dividir(double num1, double num2)
        {
            double resultado;
            resultado = num1 / num2;
            return resultado;
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "9";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtPantalla.Text);

            double Sum, Res, Mult, Div;

            if (operacion == "+") {
                Sum = Sumar(primero, segundo);
                txtPantalla.Text = Sum.ToString();
            }
            if (operacion == "-")
            {
                Res = Restar(primero, segundo);
                txtPantalla.Text = Res.ToString();
            }
            if (operacion == "*")
            {
                Mult = Multiplicar(primero, segundo);
                txtPantalla.Text = Mult.ToString();
            }
            if (operacion == "/")
            {
                Div = Dividir(primero, segundo);
                txtPantalla.Text = Div.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length == 1)
            {
                txtPantalla.Text = "";
            } else
            {
                txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            string cadena = txtPantalla.Text.ToString();
            if (!cadena.Contains(",")) { txtPantalla.Text += ","; }
        }
    }
}
