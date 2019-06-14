using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchPlays
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
            richTextBox1.BackColor = Color.DarkGray;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            this.BackColor = Color.DarkGray;            
        }

        public void AddText(string text){
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
