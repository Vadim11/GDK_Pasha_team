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
        }

        private void button3_Click(object sender, EventArgs e)  //зупинення зміни зображень
        {           
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
        }

        int trackListPosition; //позиція аудіо

        private void button5_Click_1(object sender, EventArgs e) //зупинка або початок програвання аудіо
        {           
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
        }

        private void Form1_Load(object sender, EventArgs e)  //налаштування параметрів повзунків
        {           
        }

        private void button10_Click(object sender, EventArgs e) //відображення гучгності
        {           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //вирівнювання розмірів зоьраження
        {           
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e) //перетаскування аудіо
        {            
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {           
        }            
    }
}

