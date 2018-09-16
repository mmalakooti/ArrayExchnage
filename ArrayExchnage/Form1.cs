using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ArrayExchnage
{
    public partial class Form1 : Form
    {

        int N;
        int[] ArrayL = new int[100];
        int[] ArrayR = new int[100];
        struct MyArray
         {
            int AL;
            int AR;
        }
        MyArray[] Array = new MyArray[100];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadArray_Click(object sender, EventArgs e)
        {
            string strN;
            int I;
            strN = Interaction.InputBox("Enter N", "InputBox", " ", 100, 100);
            N = Convert.ToInt32(strN);
            for (I = 1; I <= 2 * N; I++)
            {
             if(I%2==0) 
   // Even Array Elemenets
                lstLeftArray.Items.Add(I);
             else
   // Odd Array Elemenets
                 lstRightArray.Items.Add(I);
                
            }

        }

        private void btnExchangeArray_Click(object sender, EventArgs e)
        {
            int Temp, I;
            for (I = 0; I <= N-1; I++)
            {
// Exchange the Two Array elements
                MessageBox.Show("Left Array before=" + lstLeftArray.Items[I] + "    " +"Right Array before=" + lstRightArray.Items[I]);

                Temp =Convert.ToInt32(lstLeftArray.Items[I]);
                lstLeftArray.Items[I] = lstRightArray.Items[I];
                lstRightArray.Items[I] = Temp;
                MessageBox.Show("Left Array After=" + lstLeftArray.Items[I] +"     "+ "Right Array Afer=" + lstRightArray.Items[I]);

                                                             
                
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstLeftArray.Items.Clear();
            lstRightArray.Items.Clear();

        }
                
    }
}
