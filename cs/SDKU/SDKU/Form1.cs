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

        }
        static TextBox[,] numBox = new TextBox[9, 9];

        Sdku sdk = new Sdku();

        //生成方格
        void creatBox()
        {
            //int xBox = 10;
            //int yBox = 20;
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    numBox[i, j] = new TextBox();
                    numBox[i, j].Font = new Font(numBox[i, j].Font.Name, 30);
                    numBox[i, j].TextAlign = HorizontalAlignment.Center;
                    numBox[i, j].Multiline = true;
                    if (i / 3 >= 1 && i / 3 < 2)
                    {
                        numBox[i, j].Location = new Point(50 * i + 3, 50 * j);
                    }
                    else if (i / 3 >= 2)
                    {
                        numBox[i, j].Location = new Point(50 * i + 6, 50 * j);
                    }
                    else numBox[i, j].Location = new Point(50 * i, 50 * j);

                    if (j / 3 >= 1 && j / 3 < 2)
                    {
                        numBox[i, j].Location = new Point(numBox[i, j].Location.X, 50 * j + 3);
                    }
                    else if (j / 3 >= 2)
                    {
                        numBox[i, j].Location = new Point(numBox[i, j].Location.X, 50 * j + 6);
                    }
                    numBox[i, j].Name = "num" + i.ToString() + j.ToString();
                    numBox[i, j].Width = 50;
                    numBox[i, j].Height = 50;
                    numBox[i, j].MaxLength = 1;
                    numBox[i, j].TextChanged += Form1_TextChanged;
                    this.Controls.Add(numBox[i, j]);
                }
            }
        }

        //填充數字
        void fillBox()
        {
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (sdk.num[i, j] == 0)
                    {
                        numBox[i, j].Text = "";
                        numBox[i, j].Enabled = true;
                    }
                    else
                    {
                        numBox[i, j].Text = sdk.num[i, j].ToString();
                        numBox[i, j].Enabled = false;
                        numBox[i, j].ReadOnly = false;
                    }
                }
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            label1.Font = this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            clearBox();
            sdk.generate();
            fillBox();
        }
        private void clearBox()
        {
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    numBox[i, j].Text = "";
                    numBox[i, j].Enabled = true;
                }
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            fillBox();
            this.restart.Enabled = true;
            this.start.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            creatBox();
        }
        bool[,] changedBox = new bool[8, 8];
        private void Form1_TextChanged(object sender, System.EventArgs e)
        {

            this.label1.Text = "Left:" + leftBox().ToString();
            if (leftBox() == 0)
            {
                copyToNum();
                if (sdk.judgeAll())
                {
                    label1.Text = "Finished!";
                    label1.Font = this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                    MessageBox.Show("Finished");
                    for (int i = 0; i <= 8; i++)
                    {
                        for (int j = 0; j <= 8; j++)
                        {
                            numBox[i, j].Enabled = false;
                            if (sdk.num2[i, j] == 0)
                            {
                                numBox[i, j].BackColor = Color.White;
                            }
                        }
                    }
                }
            }
        }

        private int leftBox()
        {
            int lft = 0;
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (numBox[i, j].Text == "")
                    {
                        lft++;
                    }
                }
            }
            return lft;
        }
        private void copyToNum()
        {
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    sdk.num[i, j] = int.Parse(numBox[i, j].Text);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 6);

            // Create points that define line.
            Point point1 = new Point(0, 150);
            Point point2 = new Point(456, 150);

            Point point3 = new Point(0, 303);
            Point point4 = new Point(456, 303);

            Point point5 = new Point(0, 453);
            Point point6 = new Point(456, 453);

            // Draw line to screen.
            e.Graphics.DrawLine(blackPen, point1, point2);
            e.Graphics.DrawLine(blackPen, point3, point4);
            e.Graphics.DrawLine(blackPen, point3, point4);

            Point point7 = new Point(150, 0);
            Point point8 = new Point(150, 456);

            Point point9 = new Point(303, 0);
            Point point10 = new Point(303, 456);

            Point point11 = new Point(453, 0);
            Point point12 = new Point(453, 456);

            e.Graphics.DrawLine(blackPen, point7, point8);
            e.Graphics.DrawLine(blackPen, point9, point10);
            e.Graphics.DrawLine(blackPen, point11, point12);


        }
    }
}