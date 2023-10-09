﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_ornekler3
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

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            float ortalama;

            ortalama=Convert.ToSingle(txtOrtalama.Text);

            if (ortalama < 0)
            {
                lblSonuc.Text = "Negatif Değer Giremezsiniz";
            }
            else if (ortalama < 50)
            {
                lblSonuc.Text = "Kaldınız ";
            }
            else if (ortalama < 70)
            {
                lblSonuc.Text = "Tebrikler Geçtiniz";
            }
            else if (ortalama < 85)
            {
                lblSonuc.Text = "Teşekkür Belgesi aldınız ";
            }
            else if (ortalama <= 100)
            {
                lblSonuc.Text = "Taktir Belgesi aldınız";
            }
            else
            {
                lblSonuc.Text = "100'den büyük not girmeyiniz";
            }
                   
                   
            

        }
    }
}
