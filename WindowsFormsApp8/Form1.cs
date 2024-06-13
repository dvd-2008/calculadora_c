using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public enum Operacion
    {
        Nodefinida = 0,
        Suma= 1,
        Resta= 2,
        Multiplicacion= 3,
        Division = 4,
    }
    public partial class Form1 : Form
    {
        // variables : 

        double num1 = 0;
        double num2 = 0;
        Operacion operador = Operacion.Nodefinida;
        bool unNumeroLeido=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        // Funciones y metodos  : 
        private double Ejecutaropera()
        {
            double resultado = 0;
            switch (operador)
            {
              
                case Operacion.Suma:
                    resultado = num1 + num2;
                    break;
                case Operacion.Resta:
                    resultado= num1 - num2;
                    break;
                case Operacion.Multiplicacion:
                    resultado = num1 * num2;
                    break;
                case Operacion.Division:
                    if (num2 == 0)
                    {


                        label1.Text = "No se puede dividir entre 0";
                        resultado = 0;
                    }
                    else
                    {
                        resultado = num1 / num2;
                    }
                    break;
            }
            return resultado;
        }

        private void ObtenerValor(String operador)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + operador;
            textBox1.Text = "0";
        }

        private void LeerNumero(String numero)
        {
            unNumeroLeido = true;
            if (textBox1.Text == "0" && textBox1.Text != null)
            {

                textBox1.Text = numero;
            }
            else
            {
                textBox1.Text += numero;
            }

        }


        //Botones de Numeros : 


        private void button11_Click(object sender, EventArgs e)
        {
            unNumeroLeido = true;
            if (textBox1.Text == "0")
            {
                return;
            }
            else
            {
                textBox1.Text += "0";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
           LeerNumero("1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
          LeerNumero("3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
          LeerNumero("5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void button3_Click(object sender, EventArgs e)
        {
        LeerNumero("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
          LeerNumero("8");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

       
        //boton sumar
        private void button15_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");
        
        }
        //boton Restar 
        private void button16_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");
        }

        //boton Multiplicar
        private void button14_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("*");
        }

        //boton Dividir
        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor("/");
        }


        // boton resultado
        private void button12_Click(object sender, EventArgs e)
        {
            if (num2 == 0 && unNumeroLeido)
            {
                num2= Convert.ToDouble(textBox1.Text);
                label1.Text += num2 + "=";
                double resultado = Ejecutaropera();
                num1 = 0;
                num2=0;
                unNumeroLeido= false;
                textBox1.Text= Convert.ToString(resultado);

;            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                return;
            }
            textBox1.Text += ".";
        }
    }
}
