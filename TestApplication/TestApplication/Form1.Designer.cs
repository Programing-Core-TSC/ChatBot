namespace TestApplication
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
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.simpleTextBox = new System.Windows.Forms.TextBox();
            this.simpleTextButton = new System.Windows.Forms.Button();
            this.chatBotExpressions = new System.Windows.Forms.PictureBox();
            this.botNameLabel = new System.Windows.Forms.Label();
            this.userChatBox = new System.Windows.Forms.RichTextBox();
            this.userChatButton = new System.Windows.Forms.Button();
            this.submitCount = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chatBotExpressions)).BeginInit();
            this.SuspendLayout();
            // 
            // chatBox
            // 
            this.chatBox.Enabled = false;
            this.chatBox.Location = new System.Drawing.Point(12, 12);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(191, 96);
            this.chatBox.TabIndex = 0;
            this.chatBox.Text = "";
            this.chatBox.TextChanged += new System.EventHandler(this.chatBox_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(737, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(51, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Quit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 428);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(63, 13);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Your Name:";
            // 
            // simpleTextBox
            // 
            this.simpleTextBox.Location = new System.Drawing.Point(12, 114);
            this.simpleTextBox.Name = "simpleTextBox";
            this.simpleTextBox.Size = new System.Drawing.Size(100, 20);
            this.simpleTextBox.TabIndex = 4;
            // 
            // simpleTextButton
            // 
            this.simpleTextButton.Location = new System.Drawing.Point(128, 114);
            this.simpleTextButton.Name = "simpleTextButton";
            this.simpleTextButton.Size = new System.Drawing.Size(75, 23);
            this.simpleTextButton.TabIndex = 5;
            this.simpleTextButton.Text = "Submit";
            this.simpleTextButton.UseVisualStyleBackColor = true;
            this.simpleTextButton.Click += new System.EventHandler(this.simpleTextButton_Click);
            // 
            // chatBotExpressions
            // 
            this.chatBotExpressions.Image = global::TestApplication.Properties.Resources.ChatBot_Neutral;
            this.chatBotExpressions.Location = new System.Drawing.Point(629, 12);
            this.chatBotExpressions.Name = "chatBotExpressions";
            this.chatBotExpressions.Size = new System.Drawing.Size(159, 154);
            this.chatBotExpressions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chatBotExpressions.TabIndex = 6;
            this.chatBotExpressions.TabStop = false;
            // 
            // botNameLabel
            // 
            this.botNameLabel.AutoSize = true;
            this.botNameLabel.Location = new System.Drawing.Point(689, 169);
            this.botNameLabel.Name = "botNameLabel";
            this.botNameLabel.Size = new System.Drawing.Size(22, 13);
            this.botNameLabel.TabIndex = 7;
            this.botNameLabel.Text = "Me";
            // 
            // userChatBox
            // 
            this.userChatBox.Location = new System.Drawing.Point(12, 313);
            this.userChatBox.Name = "userChatBox";
            this.userChatBox.Size = new System.Drawing.Size(247, 96);
            this.userChatBox.TabIndex = 9;
            this.userChatBox.Text = "";
            // 
            // userChatButton
            // 
            this.userChatButton.Location = new System.Drawing.Point(265, 386);
            this.userChatButton.Name = "userChatButton";
            this.userChatButton.Size = new System.Drawing.Size(75, 23);
            this.userChatButton.TabIndex = 10;
            this.userChatButton.Text = "Submit";
            this.userChatButton.UseVisualStyleBackColor = true;
            this.userChatButton.Click += new System.EventHandler(this.userChatButton_Click);
            // 
            // submitCount
            // 
            this.submitCount.AutoSize = true;
            this.submitCount.Location = new System.Drawing.Point(347, 395);
            this.submitCount.Name = "submitCount";
            this.submitCount.Size = new System.Drawing.Size(125, 13);
            this.submitCount.TabIndex = 11;
            this.submitCount.Text = "Successful Submit Count";
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(372, 205);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(24, 13);
            this.test.TabIndex = 12;
            this.test.Text = "test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test);
            this.Controls.Add(this.submitCount);
            this.Controls.Add(this.userChatButton);
            this.Controls.Add(this.userChatBox);
            this.Controls.Add(this.botNameLabel);
            this.Controls.Add(this.chatBotExpressions);
            this.Controls.Add(this.simpleTextButton);
            this.Controls.Add(this.simpleTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.chatBox);
            this.Name = "Form1";
            this.Text = "ChatBot";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.chatBotExpressions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button simpleTextButton;
        public System.Windows.Forms.RichTextBox chatBox;
        public System.Windows.Forms.TextBox simpleTextBox;
        public System.Windows.Forms.Label usernameLabel;
        public System.Windows.Forms.PictureBox chatBotExpressions;
        public System.Windows.Forms.Label botNameLabel;
        public System.Windows.Forms.RichTextBox userChatBox;
        public System.Windows.Forms.Button userChatButton;
        public System.Windows.Forms.Label submitCount;
        public System.Windows.Forms.Label test;
    }
}

