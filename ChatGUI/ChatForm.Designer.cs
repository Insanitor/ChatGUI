namespace ChatGUI
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.SendButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.ChatTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromIpBox = new System.Windows.Forms.TextBox();
            this.ToIpBox = new System.Windows.Forms.TextBox();
            this.FromNameBox = new System.Windows.Forms.TextBox();
            this.ServerIpBox = new System.Windows.Forms.TextBox();
            this.ToNameBox = new System.Windows.Forms.TextBox();
            this.ServerPortBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServerPortBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(604, 406);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(68, 30);
            this.SendButton.TabIndex = 9;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.LimeGreen;
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.Location = new System.Drawing.Point(11, 58);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(91, 33);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MessageBox.Location = new System.Drawing.Point(223, 406);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(375, 29);
            this.MessageBox.TabIndex = 8;
            this.MessageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageBox_KeyDown);
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChatTextBox.Font = new System.Drawing.Font("DejaVu Serif Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatTextBox.Location = new System.Drawing.Point(223, 9);
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ReadOnly = true;
            this.ChatTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatTextBox.Size = new System.Drawing.Size(447, 391);
            this.ChatTextBox.TabIndex = 17;
            this.ChatTextBox.TabStop = false;
            this.ChatTextBox.Text = resources.GetString("ChatTextBox.Text");
            this.ChatTextBox.TextChanged += new System.EventHandler(this.ChatTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "From IP Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Server Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "To IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "From Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Server Ip Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "To Name";
            // 
            // FromIpBox
            // 
            this.FromIpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromIpBox.Location = new System.Drawing.Point(117, 199);
            this.FromIpBox.Name = "FromIpBox";
            this.FromIpBox.Size = new System.Drawing.Size(100, 22);
            this.FromIpBox.TabIndex = 7;
            this.FromIpBox.Text = "172.0.0.10";
            this.FromIpBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextTap_KeyPress);
            // 
            // ToIpBox
            // 
            this.ToIpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToIpBox.Location = new System.Drawing.Point(117, 135);
            this.ToIpBox.Name = "ToIpBox";
            this.ToIpBox.Size = new System.Drawing.Size(100, 22);
            this.ToIpBox.TabIndex = 5;
            this.ToIpBox.Text = "172.0.0.10";
            this.ToIpBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextTap_KeyPress);
            // 
            // FromNameBox
            // 
            this.FromNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromNameBox.Location = new System.Drawing.Point(11, 199);
            this.FromNameBox.Name = "FromNameBox";
            this.FromNameBox.Size = new System.Drawing.Size(100, 22);
            this.FromNameBox.TabIndex = 6;
            this.FromNameBox.Text = "FromDennis";
            this.FromNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextTap_KeyPress);
            // 
            // ServerIpBox
            // 
            this.ServerIpBox.Location = new System.Drawing.Point(11, 31);
            this.ServerIpBox.Name = "ServerIpBox";
            this.ServerIpBox.Size = new System.Drawing.Size(100, 20);
            this.ServerIpBox.TabIndex = 1;
            this.ServerIpBox.Text = "172.0.0.10";
            this.ServerIpBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextTap_KeyPress);
            // 
            // ToNameBox
            // 
            this.ToNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToNameBox.Location = new System.Drawing.Point(11, 135);
            this.ToNameBox.Name = "ToNameBox";
            this.ToNameBox.Size = new System.Drawing.Size(100, 22);
            this.ToNameBox.TabIndex = 4;
            this.ToNameBox.Text = "ToDennis";
            this.ToNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextTap_KeyPress);
            // 
            // ServerPortBox
            // 
            this.ServerPortBox.Location = new System.Drawing.Point(117, 30);
            this.ServerPortBox.Maximum = new decimal(new int[] {
            88901,
            0,
            0,
            0});
            this.ServerPortBox.Minimum = new decimal(new int[] {
            8888,
            0,
            0,
            0});
            this.ServerPortBox.Name = "ServerPortBox";
            this.ServerPortBox.Size = new System.Drawing.Size(100, 20);
            this.ServerPortBox.TabIndex = 2;
            this.ServerPortBox.Value = new decimal(new int[] {
            8890,
            0,
            0,
            0});
            this.ServerPortBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextTapNumeric_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(5, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Made by Dennis F. J. Dupont";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatGUI.Properties.Resources.HipChat;
            this.pictureBox1.Location = new System.Drawing.Point(11, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 207);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.BackColor = System.Drawing.Color.Red;
            this.DisconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectButton.Location = new System.Drawing.Point(117, 58);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(91, 33);
            this.DisconnectButton.TabIndex = 10;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = false;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(679, 446);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ServerPortBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.ChatTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FromIpBox);
            this.Controls.Add(this.ToIpBox);
            this.Controls.Add(this.FromNameBox);
            this.Controls.Add(this.ServerIpBox);
            this.Controls.Add(this.ToNameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(695, 485);
            this.MinimumSize = new System.Drawing.Size(695, 485);
            this.Name = "ChatForm";
            this.Text = "Chat Client";
            ((System.ComponentModel.ISupportInitialize)(this.ServerPortBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.RichTextBox ChatTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FromIpBox;
        private System.Windows.Forms.TextBox ToIpBox;
        private System.Windows.Forms.TextBox FromNameBox;
        private System.Windows.Forms.TextBox ServerIpBox;
        private System.Windows.Forms.TextBox ToNameBox;
        private System.Windows.Forms.NumericUpDown ServerPortBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DisconnectButton;
    }
}

