using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace character_set
{
    public partial class characterset : Form
    {
        public characterset()
        {
            InitializeComponent();
        }
    
        Random dice = new Random();
        int[] array = new int[9];

        public  int move(int STR, int DEX,int SIZ)
        {
            if (STR < SIZ && DEX < SIZ)
                return 7;
            else if (STR > SIZ && DEX > SIZ)
                return 9;
            else
                return 8;
        }

        public void bb(int STR,int SIZ)
        {
            int i = (STR + SIZ)*5;
            if (i < 64)
            {
                label24.Text = "傷害加值:" + Convert.ToString(-2);
                label25.Text = "體格:" + Convert.ToString(-2);
            }
            else if (i > 64 && i < 85)
            {
                label24.Text = "傷害加值:" + Convert.ToString(-1);
                label25.Text = "體格:" + Convert.ToString(-1);
            }
            else if (i > 84 && i < 125)
            {
                label24.Text = "傷害加值:" + Convert.ToString(0);
                label25.Text = "體格:" + Convert.ToString(0);
            }          
            else if (i > 124 && i < 165)
            {
                label24.Text = "傷害加值:" + "+1d4";
                label25.Text = "體格:" + Convert.ToString(1);
            }         
            else
            {
                label24.Text = "傷害加值:" + "+1d6";
                label25.Text = "體格:" + Convert.ToString(2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
                array[i] = 0;
            for (int i = 0; i < 9; i++)
            {
               for (int j=0; j < 3; j++)
                {
                    array[i] += dice.Next(1, 6);
                }
                array[2] = dice.Next(1,6) + dice.Next(1, 6)+6;
                array[5] = dice.Next(1, 6) + dice.Next(1, 6) + 6;
                array[6] = dice.Next(1, 6) + dice.Next(1, 6) + 6;
            }

            textBox1.Text = Convert.ToString(array[0]);//力量
            label9.Text = Convert.ToString(array[0] * 5);

            textBox2.Text = Convert.ToString(array[1]);//體質
            label10.Text = Convert.ToString(array[1] * 5);

            textBox3.Text = Convert.ToString(array[2]);//體型++
            label11.Text = Convert.ToString(array[2] * 5);

            textBox4.Text = Convert.ToString(array[3]);//敏捷
            label12.Text = Convert.ToString(array[3] * 5);

            textBox5.Text = Convert.ToString(array[4]);//外表
            label13.Text = Convert.ToString(array[4] * 5);

            textBox6.Text = Convert.ToString(array[5]);//教育++
            label14.Text = Convert.ToString(array[5] * 5);

            textBox7.Text = Convert.ToString(array[6]);//智力++
            label15.Text = Convert.ToString(array[6] * 5);

            textBox8.Text = Convert.ToString(array[7]);//意志
            label16.Text = Convert.ToString(array[7] * 5);

            textBox9.Text = Convert.ToString(array[8]);//幸運
            label20.Text = Convert.ToString(array[8] * 5);


            label21.Text = "HP:"+Convert.ToString((array[0] + array[1])*5 / 10);

            label18.Text = "MP:"+Convert.ToString(array[6]);

            label17.Text = "SAN:" + Convert.ToString(array[7]*5);

            label22.Text = "移動:" + Convert.ToString(move(array[0],array[3],array[2]));
            
            label23.Text = "閃躲:" + Convert.ToString(array[3]*5 /2);
            bb(array[0] , array[2]);
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            array[0]= dice.Next(1, 6) + dice.Next(1, 6) + dice.Next(1, 6);
            textBox1.Text = Convert.ToString(array[0]);
            label9.Text = Convert.ToString(array[0] * 5);
            label21.Text = "HP:" + Convert.ToString(5*(array[0] + array[1]) / 10);
            label22.Text = "移動:" + Convert.ToString(move(array[0], array[3], array[2]));
            bb(array[0] , array[2]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            array[1] = dice.Next(1, 6) + dice.Next(1, 6) + dice.Next(1, 6);
            textBox2.Text = Convert.ToString(array[1]);
            label10.Text = Convert.ToString(array[1] * 5);
            label21.Text = "HP:" + Convert.ToString(5*(array[0] + array[1]) / 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
             array[2] = dice.Next(1, 6) + dice.Next(1, 6) + 6;
            textBox3.Text = Convert.ToString(array[2]);
            label11.Text = Convert.ToString(array[2] * 5);
            label22.Text = "移動:" + Convert.ToString(move(array[0], array[3], array[2]));
            bb(array[0] , array[2]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            array[3] = dice.Next(1, 6) + dice.Next(1, 6) + dice.Next(1, 6);
            textBox4.Text = Convert.ToString(array[3]);
            label12.Text = Convert.ToString(array[3] * 5);
            label23.Text = "閃躲:" + Convert.ToString(array[3] * 5 / 2);
            label22.Text = "移動:" + Convert.ToString(move(array[0], array[3], array[2]));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = dice.Next(1, 6) + dice.Next(1, 6) + dice.Next(1, 6);
            textBox5.Text = Convert.ToString(i);
            label13.Text = Convert.ToString(i * 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i = dice.Next(1, 6) + dice.Next(1, 6)+ 6;
            textBox6.Text = Convert.ToString(i);
            label14.Text = Convert.ToString(i * 5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i = dice.Next(1, 6) + dice.Next(1, 6) + 6;
            textBox7.Text = Convert.ToString(i);
            label15.Text = Convert.ToString(i * 5);
            label18.Text = "MP:" + Convert.ToString(i*5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int i = dice.Next(1, 6) + dice.Next(1, 6) + dice.Next(1, 6);
            textBox8.Text = Convert.ToString(i);
            label16.Text = Convert.ToString(i * 5);
            label17.Text = "SAN:" + Convert.ToString(i*5);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int i = dice.Next(1, 6) + dice.Next(1, 6) + dice.Next(1, 6);
            textBox9.Text = Convert.ToString(i);
            label20.Text = Convert.ToString(i * 5);
        }

       
    }
}
