using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubblesort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Num = new int[10];
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            listBox1.Items.Clear();

            for (int i = 0; i < 10; i++)
            {
                Num[i] = rnd.Next(0, 1001);
                listBox1.Items.Add("Vetor = " + Num[i]);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(Num); // Ordena o vetor existente

            listBox1.Items.Clear(); // Limpa a lista
            listBox1.Items.Add("Valores Ordenados:");

            for (int i = 0; i < Num.Length; i++)
            {
                listBox1.Items.Add("Vetor = " + Num[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
