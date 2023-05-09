using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace KnopLauncher
{
    public partial class Form1 : Form
    {
        public string path = "";
        public string path2 = "";


        public Form1()
        {
            InitializeComponent();
            if (File.ReadAllText("path_to_game.txt") != "")
            {
                textBox2.Text = File.ReadAllText("path_to_game.txt"); 
            }
            if (File.ReadAllText("path_to_client.txt") != "")
            {
                пустоToolStripMenuItem2.Text = File.ReadAllText("path_to_client.txt");
            }
            if (File.ReadAllText("path_to_client.txt") != "")
            {
                пустоToolStripMenuItem3.Text = File.ReadAllText("path_to_client.txt");
            }
            if (File.ReadAllText("path_to_game.txt") != "")
            {
                пустоToolStripMenuItem4.Text = File.ReadAllText("path_to_game.txt");
            }
            if (File.ReadAllText("path_to_game.txt") != "")
            {
                пустоToolStripMenuItem5.Text = File.ReadAllText("path_to_game.txt");
            }
            if (File.ReadAllText("path_to_game.txt") != "")
            {
                пустоToolStripMenuItem.Text = File.ReadAllText("path_to_game.txt");
            }
            if (File.ReadAllText("path_to_game.txt") != "")
            {
                пустоToolStripMenuItem1.Text = File.ReadAllText("path_to_game.txt");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Process.Start(path);
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы точно хотите выйти из приложения:?", "Вы уверены :?");
            Application.Exit();
        }

        private void добавитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            label2.Show();
            textBox2.Show();
            button2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                panel1.Hide();
                label2.Hide();
                textBox2.Hide();
                button2.Hide();
                path = textBox2.Text;
                label3.Show();
                button1.Show();
                button4.Show();
                File.WriteAllText("path_to_game.txt", textBox2.Text);
                label3.Text = "Ваша игра: " + path;
            }
            else
            {
                MessageBox.Show("Чтобы добавить игру напишите путь до файла!", "Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            label2.Hide();
            textBox2.Hide();
            button2.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText("path_to_game.txt", "None");
            path = "None";
            label3.Text = "Ваша игра: " + path;
            textBox2.Text = path;
            panel1.Show();
            label2.Show();
            textBox2.Show();
            button2.Show();
        }

        private void пустоToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Show();
            label2.Show();
            textBox2.Show();
            button2.Show();
            path = textBox2.Text;
            пустоToolStripMenuItem2.Text = path;
            File.WriteAllText("path_to_client.txt", textBox2.Text);
        }

        private void пустоToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            panel1.Show();
            label2.Show();
            textBox2.Show();
            button2.Show();
            path = textBox2.Text;
            пустоToolStripMenuItem3.Text = path;
            File.WriteAllText("path_to_client.txt", textBox2.Text);
        }

        private void пустоToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            panel1.Show();
            label2.Show();
            textBox2.Show();
            button2.Show();
            path = textBox2.Text;
            пустоToolStripMenuItem3.Text = path;
            File.WriteAllText("path_to_client.txt", textBox2.Text);
        }

        private void пустоToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            panel1.Show();
            label2.Show();
            textBox2.Show();
            button2.Show();
            path = textBox2.Text;
            пустоToolStripMenuItem3.Text = path;
            File.WriteAllText("path_to_client.txt", textBox2.Text);
        }

        private void запуститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void пустоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            label2.Show();
            textBox2.Show();
            button2.Show();
            path = textBox2.Text;
            пустоToolStripMenuItem3.Text = path;
            File.WriteAllText("path_to_game.txt", textBox2.Text);
        }

        private void пустоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            label2.Show();
            textBox2.Show();
            button2.Show();
            path = textBox2.Text;
            пустоToolStripMenuItem3.Text = path;
            File.WriteAllText("path_to_game.txt", textBox2.Text);
        }

        private void запуститьИгрыВБиблеотекиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            path = File.ReadAllText("path_to_client.txt");
            path2 = File.ReadAllText("path_to_game.txt");
            if (path2 != "None" && path != "None")
            {
                Process.Start(path2);
                Process.Start(path);
            }
        }
    }
}
