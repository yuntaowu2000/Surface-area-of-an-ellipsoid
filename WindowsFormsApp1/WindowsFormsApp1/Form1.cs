using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z1, z2, z3, t1, t2, t3, a, b, c, s;
            s = 0;
                for (y = 0; y <= 7182; y++)
                {
                    for(x=0;x<=10610;x++)
                    {
                        t1 = 1 - x * x / (10610 * 10610) - y * y / (7182 * 7182);
                        t2 = 1 - (x + 1) * (x + 1) / (10610 * 10610) - y * y / (7182 * 7182);
                        t3 = 1 - x * x / (10610 * 10610) - (y + 1) * (y + 1) / (7182 * 7182);
                        if (t1 > 0 & t2 > 0 & t3 > 0)
                        {
                            z1 = 4668 * Math.Sqrt(t1);
                            z2 = 4668 * Math.Sqrt(t2);
                            z3 = 4668 * Math.Sqrt(t3);
                            a = z1 - z2;
                            b = z1 - z3;
                            c = 0.5 * Math.Sqrt(a*a*b*b+a * a + b * b + 1);
                            s = s + c;

                        }

                    }
                } 
                for(y=1;y<=7182;y++)
            {
                    for(x=0;x<=10610; x++)
                {
                    t1 = 1 - x * x / (10610 * 10610) - y * y / (7182 * 7182);
                    t2 = 1 - (x + 1) * (x + 1) / (10610 * 10610) - y * y / (7182 * 7182);
                    t3 = 1 - (x + 1) * (x + 1) / (10610 * 10610) - (y - 1) * (y - 1) / (7182 * 7182);
                    if(t1>0 & t2>0 & t3>0)
                    {
                        z1 = 4668 * Math.Sqrt(t1);
                        z2 = 4668 * Math.Sqrt(t2);
                        z3 = 4668 * Math.Sqrt(t3);
                        a = z1 - z2;
                        b = z2 - z3;
                        c = 0.5 * Math.Sqrt(a*a*b*b+a * a + b * b + 1);
                        s = s + c;


                    }

                }
            }
            string str = Convert.ToString(s);
            textBox1.Text = str;
                
        }
    }
}
