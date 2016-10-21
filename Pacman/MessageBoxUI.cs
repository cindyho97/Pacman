﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class MessageBoxUI : UserControl
    {
        MessageBoxController messageBoxController;

        public MessageBoxUI(MessageBoxController controller)
        {
            messageBoxController = controller;
            InitializeComponent();
        }

        //update message label with new text
        public void updateText(string newText)
        {
            this.messageTextLabel.Text = newText;
        }
    }
}
