﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLibrary;

//7. Дан список вещественных чисел. Для каждого элемента списка напечатать число
 //    отрицательных элементов, следующих за ним.

namespace _3._1._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            MyList list = ConvertUtils.StrToMyList(textBoxInput.Text);
            list.GetList();
            textBoxOutput.Text = ConvertUtils.MyListToStr(list);
        }
    }
}
