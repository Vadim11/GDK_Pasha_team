using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {            
            InitializeComponent();
        }

        public void Settings(int min, int max, int step) //налаштування параметрів повзунка
        {
            trackBar1.Minimum = min;
            trackBar1.Maximum = max;
            trackBar1.TickFrequency = step;
        }

        public int Value  //отримання значення повзунка
        {
            get { return trackBar1.Value;}
        }

        private void trackBar1_Scroll(object sender, EventArgs e)  
        {
            if (this.Name == "userControl11")  // якщо повзунок швидкості
                label1.Text = trackBar1.Value.ToString()+ " c.";
            else                               //якщо повзунок гучності
                label1.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {                      
            if (this.Name == "userControl11")
                if (trackBar1.Value==0) //якщо 0 швидкіть зупиняєм таймер
                {
                    ((Form1)this.Parent.Parent.Parent.Parent).timer1.Stop();
                    ((Form1)this.Parent.Parent.Parent.Parent).button3.Enabled=false;
                    ((Form1)this.Parent.Parent.Parent.Parent).button2.Enabled=true;
                }
                else
                    ((Form1)this.Parent.Parent.Parent.Parent).timer1.Interval = trackBar1.Value*1000;  //встановлюєм затримку в секундах
            else
                ((Form1)this.Parent.Parent.Parent.Parent).axWindowsMediaPlayer1.settings.volume = trackBar1.Value ;  //встановюємо гучність
            this.Visible = false; //ховаємо елемент
        }               

    }
}
