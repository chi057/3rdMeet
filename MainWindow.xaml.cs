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
                txtMG.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtG.Text = string.Format("{0:0.##########}", _value / 1000);
            if (_kind != 2)
                txtKG.Text = string.Format("{0:0.##########}", _value / 1000000);
            if (_kind != 3)
                txtT.Text = string.Format("{0:0.##########}", _value * 0.000000001);
            if (_kind != 4)
                txtOZ.Text = string.Format("{0:0.##########}", _value * 0.000035273962);
            if (_kind != 5)
                txtP.Text = string.Format("{0:0.##########}", _value * 0.000002204623);
        }
        private void BtnAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtMG.Text = "";
            txtG.Text = "";
            txtKG.Text = "";
            txtT.Text = "";
            txtOZ.Text = "";
            txtP.Text = "";
        }
        private void TxtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtMG.Text; 
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtMG.Text = "";
            }
        }
        private void TxtCM_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TxtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtG.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput * 1000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtG.Text = "";
            }    
        }
        private void TxtKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKG.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 1000000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKG.Text = "";
            } 
        }
        private void TxtIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtT.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput / 0.000000001);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtT.Text = "";
            } 
        }
        private void TxtFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtOZ.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput / 0.000035273962);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtOZ.Text = "";
            }  
        }
        private void TxtYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtP.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput / 0.000002204623);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtP.Text = "";
            }  
        }
    }
}
