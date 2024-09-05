using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hshop_Terminal_v1._0
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
            pathBox.KeyPress += pathBox_KeyPress;
        }
        private void pathBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string value = pathBox.Text;
                parentForm.setPathOpenFile(value);
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string appDirectory = Application.StartupPath;
            appDirectory = Path.Combine(appDirectory, "path.txt");
            using (StreamReader sr = new StreamReader(appDirectory))
            {
                string content = sr.ReadToEnd();
                pathBox.Text = content;
            }
        }
    }
}
