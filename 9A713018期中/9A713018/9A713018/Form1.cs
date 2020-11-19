using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9A713018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
            
        {
            try
            {
                
                string input_str = tbInput.Text;
                
                int input_int = int.Parse(input_str);

                

                
                MessageBox.Show($"{input_int}", "Num", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                
                MessageBox.Show($"請打數字!!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
