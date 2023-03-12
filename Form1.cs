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

            //альтернативное задание пути к исполняемому файлу для свойства FileName объекта StartInfo: 
            //CalcProcess.StartInfo.FileName = "calc.exe";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CalcProcess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting Calculator process: " + ex.Message);
            }
        }
              

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.GetProcessesByName("calc").First().Kill();
                //calc is correct process name in Windows 7
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error killing Calculator process: " + ex.Message);
            }
        }
    }
}
