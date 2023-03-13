﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3rdMeet
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TxtCM_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM;

            douCM = Convert.ToDouble(txtCM.Text);

            txtM.Text = string.Format("{0:0.##########}", douCM / 100);
            txtKM.Text = string.Format("{0:0.##########}", douCM / 100000);
            txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54);
            txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48);
            txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);
        }
        private void TxtCM_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtM_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TxtKM_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TxtIn_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TxtFt_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TxtYard_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
