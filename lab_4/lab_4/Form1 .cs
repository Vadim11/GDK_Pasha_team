using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;


namespace lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> audiopath = new List<string>(); //список шляхів до аудіо
        List<string> picturepath = new List<string>();  //список шляхів до фото
        int i = 0; //лічильник


        private void button1_Click(object sender, EventArgs e) //діалог вибору фото
        {

            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string d = openFileDialog1.FileName;
                foreach (String file in openFileDialog1.FileNames)
                {
                    picturepath.Add(file);
                    listBox1.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //початок показу зображень
        {
            if (picturepath.Count != 0)
            {
                pictureBox1.ImageLocation = picturepath[i];
                timer1.Start();
                button3.Enabled = true;
                button2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Немає даних для відображення", "Помилка");
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //зміна зображення і заголовка
        {           
            if (picturepath.Count != 0)
                pictureBox1.ImageLocation = picturepath[i++];
            if (i == picturepath.Count) i = 0;
            //якщо є і ауліо і фото
            if (picturepath.Count > 0 && audiopath.Count>0)
                this.Text = "Picture: " + Path.GetFileName(picturepath[i]) + ";   Audio: " + Path.GetFileName(audiopath[trackListPosition]); 
            //якщо є фото
            if (picturepath.Count > 0)
                this.Text = "Picture: " + Path.GetFileName(picturepath[i]);
            //якщо є аудіо
            if (audiopath.Count>0)
                this.Text += "Audio: " + Path.GetFileName(audiopath[trackListPosition]);
            listBox1.SelectedIndex = i;  //позиція поточного фото в списку
        }
       
        private void listBox1_DragDrop(object sender, DragEventArgs e) //обробка події паратягування файлів
        {
           
        }

        private void button3_Click(object sender, EventArgs e)  //зупинення зміни зображень
        {
            timer1.Stop(); 
            button2.Enabled = true;
            button3.Enabled = false;
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e) // контекстне меню видалення фото з списку
        {
           
        }

        private void button4_Click(object sender, EventArgs e) //діалог вибору аудіо
        {                       
        }       

        private void listBox2_DoubleClick(object sender, EventArgs e) //програвання аудіо при подвійному кліку
        {
            for (int n = 0; n < audiopath.Count; n++)
            {
                if (audiopath[n].EndsWith(listBox2.SelectedItem.ToString()))
                {
                    axWindowsMediaPlayer1.URL = audiopath[n];
                    trackListPosition = n;  // збереження позиції аудіо
                    break;
                }
            }
        }

        int trackListPosition; //позиція аудіо

        private void button5_Click_1(object sender, EventArgs e) //зупинка або початок програвання аудіо
        {
           
        }

        private void button6_Click_1(object sender, EventArgs e) //приховування панелі
        {            
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.Panel1.Hide();
        }                          
       
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) //при наближенні вказівника до краю форми відображається панель
        {
            if (e.X <= 20)
            {
                splitContainer1.Panel1Collapsed = false;
                splitContainer1.Panel1.Show();
            }
        }               
        
        private void button8_Click(object sender, EventArgs e) //кнопка управління плеєром - назад
        {
            if (trackListPosition != 0)
            {
                axWindowsMediaPlayer1.URL = audiopath[trackListPosition - 1];
                trackListPosition = trackListPosition - 1;
                listBox2.SelectedIndex = trackListPosition;
            }
            else
            {
                axWindowsMediaPlayer1.URL = audiopath[audiopath.Count() - 1];
                trackListPosition = audiopath.Count();
                listBox2.SelectedIndex = trackListPosition;
            }
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button9_Click(object sender, EventArgs e) //кнопка управління плеєром - вперед
        {
            if (trackListPosition != audiopath.Count() - 1)
            {
                axWindowsMediaPlayer1.URL = audiopath[trackListPosition + 1];
                trackListPosition = trackListPosition + 1;
                listBox2.SelectedIndex = trackListPosition;
            }
            else
            {
                axWindowsMediaPlayer1.URL = audiopath[0];
                trackListPosition = 0;
                listBox2.SelectedIndex = trackListPosition;
            }
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button7_Click_1(object sender, EventArgs e) //відображення швидкості
        {
            userControl11.Visible = true;            
        }

        private void Form1_Load(object sender, EventArgs e)  //налаштування параметрів повзунків
        {
            userControl11.Settings(0, 60, 5);
            userControl12.Settings(0, 100, 5);
        }

        private void button10_Click(object sender, EventArgs e) //відображення гучгності
        {
            userControl12.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //вирівнювання розмірів зоьраження
        {
            if (checkBox1.Checked)
                this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            else
                this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;

        }

        private void listBox2_DragDrop(object sender, DragEventArgs e) //перетаскування аудіо
        {
           
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
           
        }            
    }
}

