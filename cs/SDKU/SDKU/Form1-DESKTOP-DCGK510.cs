using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDKU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            creatBox();
        }
        //記得使用textbox的tofront方法
        TextBox[,] numBox = new TextBox[9, 9];

        Sdku sdk = new Sdku();
        void creatBox()
        {

            //int xBox = 10;
            //int yBox = 20;
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    numBox[i, j] = new TextBox();
                    numBox[i, j].Multiline = true;
                    numBox[i, j].Location = new Point(50*i, 50*j);
                    numBox[i, j].Name = "num" + i.ToString();
                    numBox[i, j].Width = 50;
                    numBox[i, j].Height = 50;
                    this.Controls.Add(numBox[i, j]);
                }
            }
        }
        void fillBox()
        {
            for (int i = 0; i <= 8; i++)
            {

            }
        }
    }
}
