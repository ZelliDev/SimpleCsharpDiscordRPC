﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;

namespace SimpleCsharpDiscordRPC
{
    public partial class MainForm : Form
    {
        public DiscordRpcClient client;
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void btn_send_Click(object sender, EventArgs e)
        {
            client = new DiscordRpcClient(tb_ClientID.Text);

            
            client.Initialize();

          
            client.SetPresence(new RichPresence()
            {
                Details = tb_details.Text,
                State = tb_state.Text,
                Assets = new Assets()
                {
                    LargeImageKey = tb_imagelarge.Text,
                    LargeImageText = tb_imagelarge.Text,
                    SmallImageKey = tb_littleimage.Text
                }
            });
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            client.Dispose();
            
        }

        private void btn_forcequit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
