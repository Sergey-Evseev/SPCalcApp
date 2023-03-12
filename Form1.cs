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

namespace SPCalcApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CalcProcess.StartInfo = new ProcessStartInfo("calc.exe");
            //создает новый экземпляр класса ProcessStartInfo и присваивает
            //его свойству StartInfo объекта класса Process с именем CalcProcess
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcProcess.Start();
        }
              

        private void button2_Click_1(object sender, EventArgs e)
        {
            //CalcProcess.CloseMainWindow();
            //CalcProcess.Kill();
            Process.GetProcessesByName("CalculatorApp").First().Kill();
        }
    }
}
