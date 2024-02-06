using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_örnek2
{
    public partial class Form1 : Form
    {
        Queue<string>musteri=new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void musteriCagir(Label lbl)
        {
            try
            {
                lbl.Text = musteri.Dequeue();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            musteri.Enqueue("İrem");
            musteri.Enqueue("Leyla");
            musteri.Enqueue("Yasemin");
        }

        private void btnSiraAl_Click(object sender, EventArgs e)
        {
            musteri.Enqueue(txtAd.Text);
        }

        private void btnGise1_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSira1);
        }

        private void btnGise2_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSira2);
        }

        private void btnGise3_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSira3);
        }
    }
}
