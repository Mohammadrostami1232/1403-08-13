using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    public class car
    {
        private string model;
        private string rang;
        public car(string Model, string Rang)
        {
            Model = model;
            Rang = rang;
            model = "ford shelby GT500KR";
            rang = "silver and bluee";
        }
        ~car()
        {
            MessageBox.Show($"model:{model} , rang:{rang}");
        }
    }
        private void button1_Click(object sender, EventArgs e)
        {
            car mycar = new car("ford shelby GT500KR", "silver and bluee");
        }
    }

    
}
