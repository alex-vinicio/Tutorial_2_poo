using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poo_animales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Animal gato1 = new Animal("Batman",3);
            respuesta1.Text = "Nombre: " + gato1.NombreA + ", Edad: " + gato1.EdadA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            herbívoro herv1 = new herbívoro(null,null,15);
            herv1.setTipoComida("pazto");
            herv1.NombreA = nombreA.Text;
            herv1.EdadA = Int32.Parse(edadA.Text);

            respuesta1.Text = "Nombre: " + herv1.NombreA + ", Edad: " + herv1.EdadA+" Tipo comida: " + herv1.getTipoComida();

            if(metodoA.Text == "Comer")
            {
                respuesta2.Text = herv1.comerAniaml();
            }
            else
            {
                if(metodoA.Text == "Caminar")
                {
                    respuesta2.Text = herv1.caminarAnimal();
                }
                else
                {
                    respuesta2.Text = herv1.noComo();
                }
            }
        }

        private void buscarA_Click(object sender, EventArgs e)
        {

        }
    }
}
