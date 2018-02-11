using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Europahelper
{
    public partial class Form1 : Form
    {
        Thread AddressCdtListener;
        bool needToClose;
        public Form1()
        {
            needToClose = false;
            AddressCdtListener = new Thread(AddressCdtMethod);
            InitializeComponent();
        }

        private void AddressCdtMethod()
        {
            while(needToClose!=false)
            {
                 
            }
        }

        private void IntermeneUI()
        {

        }

        private string RequestUIValue()
        {
            return "";
        }



        private void BnTargetChoice_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, EventArgs e)
        {
            needToClose = true;
            AddressCdtListener.Abort();
        }
    }
}
