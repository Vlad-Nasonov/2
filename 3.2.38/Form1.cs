using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLibrary;

//38. Создать очередь, информационные поля которой содержат вещественные числа из текстового файла.
 //   Проверить, упорядочены ли числа по возрастанию или по убыванию.

namespace _3._2._38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    originalTextBox.Text = FileUtility.FileToString(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при открытии файла");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            MyQueue queue = FileUtility.FileToMyQueue(openFileDialog1.FileName);
            int res = queue.VozrOrYbuv();
            if (res == 1)
                resultLabel.Text = "Последовательность возрастает";
            else if (res == -1)
                resultLabel.Text = "Последовательность убывает";
            else
                resultLabel.Text = "Последовательность не возрастает и не убывает";

        }
    }
}
