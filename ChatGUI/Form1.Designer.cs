﻿namespace ChatGUI
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.ServerPortBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(602, 406);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(66, 29);
            this.SendButton.TabIndex = 19;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(11, 58);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 20;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBox.Location = new System.Drawing.Point(223, 406);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(373, 29);
            this.MessageBox.TabIndex = 18;
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.Location = new System.Drawing.Point(223, 9);
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.Size = new System.Drawing.Size(447, 391);
            this.ChatTextBox.TabIndex = 17;
            this.ChatTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
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
            this.label3.Location = new System.Drawing.Point(117, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "To IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
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
            this.label1.Location = new System.Drawing.Point(11, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "To Name";
            // 
            // FromIpBox
            // 
            this.FromIpBox.Location = new System.Drawing.Point(117, 179);
            this.FromIpBox.Name = "FromIpBox";
            this.FromIpBox.Size = new System.Drawing.Size(100, 20);
            this.FromIpBox.TabIndex = 5;
            this.FromIpBox.Text = "172.0.0.10";
            // 
            // ToIpBox
            // 
            this.ToIpBox.Location = new System.Drawing.Point(117, 135);
            this.ToIpBox.Name = "ToIpBox";
            this.ToIpBox.Size = new System.Drawing.Size(100, 20);
            this.ToIpBox.TabIndex = 7;
            this.ToIpBox.Text = "172.0.0.10";
            // 
            // FromNameBox
            // 
            this.FromNameBox.Location = new System.Drawing.Point(11, 179);
            this.FromNameBox.Name = "FromNameBox";
            this.FromNameBox.Size = new System.Drawing.Size(100, 20);
            this.FromNameBox.TabIndex = 8;
            this.FromNameBox.Text = "FromDennis";
            // 
            // ServerIpBox
            // 
            this.ServerIpBox.Location = new System.Drawing.Point(11, 31);
            this.ServerIpBox.Name = "ServerIpBox";
            this.ServerIpBox.Size = new System.Drawing.Size(100, 20);
            this.ServerIpBox.TabIndex = 9;
            this.ServerIpBox.Text = "172.0.0.10";
            // 
            // ToNameBox
            // 
            this.ToNameBox.Location = new System.Drawing.Point(11, 135);
            this.ToNameBox.Name = "ToNameBox";
            this.ToNameBox.Size = new System.Drawing.Size(100, 20);
            this.ToNameBox.TabIndex = 10;
            this.ToNameBox.Text = "ToDennis";
            // 
            // ServerPortBox
            // 
            this.ServerPortBox.Location = new System.Drawing.Point(117, 30);
            this.ServerPortBox.Maximum = new decimal(new int[] {
            9999,
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
            this.ServerPortBox.TabIndex = 21;
            this.ServerPortBox.Value = new decimal(new int[] {
            8888,
            0,
            0,
            0});
            this.ServerPortBox.ValueChanged += new System.EventHandler(this.ServerPortBox_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.ServerPortBox);
            this.Controls.Add(this.SendButton);
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
            this.Name = "Form1";
            this.Text = "Chat Server GUI";
            ((System.ComponentModel.ISupportInitialize)(this.ServerPortBox)).EndInit();
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
    }
}

