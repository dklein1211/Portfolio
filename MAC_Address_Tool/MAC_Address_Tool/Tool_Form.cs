using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAC_Address_Tool
{
    public partial class Tool_Form : Form
    {
        public Tool_Form()
        {
            InitializeComponent();
            this.Text = "MAC Address Converter";
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            CleanUpMethods convertList = new CleanUpMethods(); //Initialize the class
            textBoxOutput.Text = convertList.RegexString(textBoxOutput.Text); //Removes everything
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
        }
    }
}
