﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormInWhile
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }
        public MessageForm(String name, string body) : this()
        {
            Text = name;
            richTextBox1.Text = body;

        }
        private void MessageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
