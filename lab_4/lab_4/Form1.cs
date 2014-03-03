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
        }

        private void button2_Click(object sender, EventArgs e) //початок показу зображень
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e) //зміна зображення і заголовка
        {                       
        }
       
        private void listBox1_DragDrop(object sender, DragEventArgs e) //обробка події паратягування файлів
        {
            foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                //якщзо файл є картинкою додаємо в списки
                if ((Path.GetFileName(file).EndsWith("bmp")) || (Path.GetFileName(file).EndsWith("jpg")) || (Path.GetFileName(file).EndsWith("jpeg")) || (Path.GetFileName(file).EndsWith("png")))
                {
                    picturepath.Add(file);
                    listBox1.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)  //зупинення зміни зображень
        {            
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e) // контекстне меню видалення фото з списку
        {
            for (int n = 0; n < picturepath.Count; n++)
            {
                if (listBox1.SelectedIndex != -1)
                    if (picturepath[n].EndsWith(listBox1.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Зображення " + listBox1.SelectedItem.ToString() + " видалено зі списку відворення", "Видалення");
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        picturepath.Remove(picturepath[n]);
                        break;
                    }
            }
        }

        private void button4_Click(object sender, EventArgs e) //діалог вибору аудіо
        {           
            openFileDialog1.Filter = "Audio Files(*.MP3)|*.mp3|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string d = openFileDialog1.FileName;
            foreach (String file in openFileDialog1.FileNames)
            {
                audiopath.Add(file);
                listBox2.Items.Add(Path.GetFileName(file));               
            }
        }       

        private void listBox2_DoubleClick(object sender, EventArgs e) //програвання аудіо при подвійному кліку
        {

        }

        int trackListPosition; //позиція аудіо

        private void button5_Click_1(object sender, EventArgs e) //зупинка або початок програвання аудіо
        {
            if (button5.Text == "Play")
            {
                if (listBox2.SelectedIndex < 0)
                    listBox2.SelectedIndex = 0;
                for (int n = 0; n < audiopath.Count; n++)
                {
                    if (audiopath[n].EndsWith(listBox2.SelectedItem.ToString()))
                    {
                        axWindowsMediaPlayer1.URL = audiopath[n];
                        trackListPosition = n;
                        break;
                    }
                }
                axWindowsMediaPlayer1.Ctlcontrols.play();
                button5.Text = "Stop";
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                button5.Text = "Play";
            }
        }

        private void button6_Click_1(object sender, EventArgs e) //приховування панелі
        {            
           
        }                          
       
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) //при наближенні вказівника до краю форми відображається панель
        {
            
        }               
        
        private void button8_Click(object sender, EventArgs e) //кнопка управління плеєром - назад
        {
            
        }

        private void button9_Click(object sender, EventArgs e) //кнопка управління плеєром - вперед
        {
            
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
          
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e) //перетаскування аудіо
        {
            foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (Path.GetFileName(file).EndsWith("mp3"))
                {
                    audiopath.Add(file);
                    listBox2.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }            
    }
}

