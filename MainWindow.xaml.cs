using System;
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
        string strInput; 
        double douOutput;
        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtCM.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtM.Text = string.Format("{0:0.##########}", _value / 100);
            if (_kind != 2)
                txtKM.Text = string.Format("{0:0.##########}", _value / 100000);
            if (_kind != 3)
                txtIn.Text = string.Format("{0:0.##########}", _value / 2.54);
            if (_kind != 4)
                txtFt.Text = string.Format("{0:0.##########}", _value / 30.48);
            if (_kind != 5)
                txtYard.Text = string.Format("{0:0.##########}", _value / 91.44);
        }
        private void BtnAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }
        private void TxtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text; 
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }
        private void TxtCM_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TxtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput * 100);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }    
        }
        private void TxtKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 100000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKM.Text = "";
            } 
        }
        private void TxtIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtIn.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput * 2.54);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtIn.Text = "";
            } 
        }
        private void TxtFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtFt.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput * 30.48);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtFt.Text = "";
            }  
        }
        private void TxtYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtYard.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput * 91.44);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }  
        }
    }
}
