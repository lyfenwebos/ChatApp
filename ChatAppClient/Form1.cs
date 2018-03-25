using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox.AcceptsReturn = false;
            textBox.KeyDown += TextBox_KeyDown;
            textBox.TextChanged += TextBox_TextChanged;
            textBox.Focus();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text == "\r\n")
            {
                textBox.Clear();
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && Control.ModifierKeys == Keys.Shift)
            {
                textBox.AppendText("\r");
            }

            else if (e.KeyCode == Keys.Enter&&textBox.Text.Length>1)
            {
                //SendMessage
                messageTextBox.AppendText("Nickname:"+"\r\n"+ textBox.Text);
                textBox.Clear();

            }
        }


    }
}
