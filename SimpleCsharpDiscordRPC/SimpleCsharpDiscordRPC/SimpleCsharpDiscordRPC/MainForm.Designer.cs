namespace SimpleCsharpDiscordRPC
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ClientID = new System.Windows.Forms.Label();
            this.tb_ClientID = new System.Windows.Forms.TextBox();
            this.tb_details = new System.Windows.Forms.TextBox();
            this.lbl_Details = new System.Windows.Forms.Label();
            this.tb_state = new System.Windows.Forms.TextBox();
            this.lbl_state = new System.Windows.Forms.Label();
            this.tb_imagelarge = new System.Windows.Forms.TextBox();
            this.lbl_largeimage = new System.Windows.Forms.Label();
            this.tb_largeImageText = new System.Windows.Forms.TextBox();
            this.lbl_largeimageText = new System.Windows.Forms.Label();
            this.tb_littleimage = new System.Windows.Forms.TextBox();
            this.lbl_littleimage = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_forcequit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ClientID
            // 
            this.lbl_ClientID.AutoSize = true;
            this.lbl_ClientID.Location = new System.Drawing.Point(52, 77);
            this.lbl_ClientID.Name = "lbl_ClientID";
            this.lbl_ClientID.Size = new System.Drawing.Size(50, 13);
            this.lbl_ClientID.TabIndex = 0;
            this.lbl_ClientID.Text = "Client_ID";
            // 
            // tb_ClientID
            // 
            this.tb_ClientID.Location = new System.Drawing.Point(123, 74);
            this.tb_ClientID.Name = "tb_ClientID";
            this.tb_ClientID.Size = new System.Drawing.Size(166, 20);
            this.tb_ClientID.TabIndex = 1;
            // 
            // tb_details
            // 
            this.tb_details.Location = new System.Drawing.Point(123, 117);
            this.tb_details.Name = "tb_details";
            this.tb_details.Size = new System.Drawing.Size(128, 20);
            this.tb_details.TabIndex = 3;
            // 
            // lbl_Details
            // 
            this.lbl_Details.AutoSize = true;
            this.lbl_Details.Location = new System.Drawing.Point(52, 120);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(39, 13);
            this.lbl_Details.TabIndex = 2;
            this.lbl_Details.Text = "Détails";
            // 
            // tb_state
            // 
            this.tb_state.Location = new System.Drawing.Point(123, 153);
            this.tb_state.Name = "tb_state";
            this.tb_state.Size = new System.Drawing.Size(128, 20);
            this.tb_state.TabIndex = 5;
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(65, 156);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(26, 13);
            this.lbl_state.TabIndex = 4;
            this.lbl_state.Text = "État";
            // 
            // tb_imagelarge
            // 
            this.tb_imagelarge.Location = new System.Drawing.Point(123, 189);
            this.tb_imagelarge.Name = "tb_imagelarge";
            this.tb_imagelarge.Size = new System.Drawing.Size(128, 20);
            this.tb_imagelarge.TabIndex = 7;
            // 
            // lbl_largeimage
            // 
            this.lbl_largeimage.AutoSize = true;
            this.lbl_largeimage.Location = new System.Drawing.Point(48, 192);
            this.lbl_largeimage.Name = "lbl_largeimage";
            this.lbl_largeimage.Size = new System.Drawing.Size(69, 13);
            this.lbl_largeimage.TabIndex = 6;
            this.lbl_largeimage.Text = "Image Large ";
            // 
            // tb_largeImageText
            // 
            this.tb_largeImageText.Location = new System.Drawing.Point(123, 215);
            this.tb_largeImageText.Name = "tb_largeImageText";
            this.tb_largeImageText.Size = new System.Drawing.Size(128, 20);
            this.tb_largeImageText.TabIndex = 9;
            // 
            // lbl_largeimageText
            // 
            this.lbl_largeimageText.AutoSize = true;
            this.lbl_largeimageText.Location = new System.Drawing.Point(48, 218);
            this.lbl_largeimageText.Name = "lbl_largeimageText";
            this.lbl_largeimageText.Size = new System.Drawing.Size(66, 13);
            this.lbl_largeimageText.TabIndex = 8;
            this.lbl_largeimageText.Text = "Texte Image";
            // 
            // tb_littleimage
            // 
            this.tb_littleimage.Location = new System.Drawing.Point(123, 241);
            this.tb_littleimage.Name = "tb_littleimage";
            this.tb_littleimage.Size = new System.Drawing.Size(128, 20);
            this.tb_littleimage.TabIndex = 11;
            // 
            // lbl_littleimage
            // 
            this.lbl_littleimage.AutoSize = true;
            this.lbl_littleimage.Location = new System.Drawing.Point(48, 244);
            this.lbl_littleimage.Name = "lbl_littleimage";
            this.lbl_littleimage.Size = new System.Drawing.Size(66, 13);
            this.lbl_littleimage.TabIndex = 10;
            this.lbl_littleimage.Text = "Petite Image";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(92, 277);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 12;
            this.btn_send.Text = "Connect";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(173, 277);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(89, 23);
            this.btn_disconnect.TabIndex = 13;
            this.btn_disconnect.Text = "Déconnecter";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_forcequit
            // 
            this.btn_forcequit.Location = new System.Drawing.Point(268, 277);
            this.btn_forcequit.Name = "btn_forcequit";
            this.btn_forcequit.Size = new System.Drawing.Size(89, 23);
            this.btn_forcequit.TabIndex = 14;
            this.btn_forcequit.Text = "Force Déco";
            this.btn_forcequit.UseVisualStyleBackColor = true;
            this.btn_forcequit.Click += new System.EventHandler(this.btn_forcequit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 312);
            this.Controls.Add(this.btn_forcequit);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_littleimage);
            this.Controls.Add(this.lbl_littleimage);
            this.Controls.Add(this.tb_largeImageText);
            this.Controls.Add(this.lbl_largeimageText);
            this.Controls.Add(this.tb_imagelarge);
            this.Controls.Add(this.lbl_largeimage);
            this.Controls.Add(this.tb_state);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.tb_details);
            this.Controls.Add(this.lbl_Details);
            this.Controls.Add(this.tb_ClientID);
            this.Controls.Add(this.lbl_ClientID);
            this.Name = "MainForm";
            this.Text = "Simple C# Discord RPC";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ClientID;
        private System.Windows.Forms.TextBox tb_ClientID;
        private System.Windows.Forms.TextBox tb_details;
        private System.Windows.Forms.Label lbl_Details;
        private System.Windows.Forms.TextBox tb_state;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.TextBox tb_imagelarge;
        private System.Windows.Forms.Label lbl_largeimage;
        private System.Windows.Forms.TextBox tb_largeImageText;
        private System.Windows.Forms.Label lbl_largeimageText;
        private System.Windows.Forms.TextBox tb_littleimage;
        private System.Windows.Forms.Label lbl_littleimage;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_forcequit;
    }
}