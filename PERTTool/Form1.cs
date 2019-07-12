using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERTTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            graphTool1.Weight = (int)numericUpDown1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            graphTool1.Activity = textBox1.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            graphTool1.Path = textBox2.Text;
            graphTool1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(var i in graphTool1.Paths())
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click izquierdo: Agregar un nodo con el nombre del primer textbox\nClick derecho: Seleccionar un nodo\nPresionar rueda: crear camino entre 2 nodos con nombre y peso definidos por el primer textbox y el numeric respectivamente\nF: Eliminar nodo (y sus caminos relacionados)\n[WSAD]: Mover el area visible, o mover un nodo si hay uno seleccionado\n-: Zoom out\n+: Zoom in", "Ayuda");
        }
    }
}
