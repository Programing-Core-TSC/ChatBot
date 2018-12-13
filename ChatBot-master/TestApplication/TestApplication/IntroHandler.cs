//This file handles all of the intro sequence. Not the cleanest, but it works pretty well!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplication
{
    public class IntroHandler
    {
        public int pauseSeconds;
        public string chatBoxText;
        public char currentChar;
        public int currentCharInt = 0;
        public string placeholder;
        public int introText;
        public Timer textTimer = new Timer();
        public Timer textPause = new Timer();
        public bool inIntro = true;
        public string username;
        public string botname;

        public void TextEventHandler(object myObject, EventArgs myEventArgs)
        {
            if (currentCharInt != chatBoxText.Length)
            {
                currentChar = chatBoxText[currentCharInt];
                placeholder = currentChar.ToString();
                Form1.form.chatBox.AppendText(placeholder);
                currentCharInt++;
            }
            else if (currentCharInt == chatBoxText.Length)
            {
                textPause.Start();
                textTimer.Stop();
                currentCharInt = 0;
            }
            else
            {
                Form1.form.chatBox.AppendText("ERROR!");
            }
        }
        public void PauseEventHandler(object myObject, EventArgs myEventArgs)
        {
            pauseSeconds++;
            if (pauseSeconds == 2)
            {
                textPause.Stop();
                pauseSeconds = 0;
                Form1.form.chatBox.Clear();
                introText++;
                if (inIntro == true)
                {
                    switch (introText)
                    {
                        case 0:
                            chatBoxText = "BUG: THIS MESSAGE SHOULD HAVE ALREADY RUN";
                            textTimer.Start();
                            break;
                        case 1:
                            chatBoxText = "I am a ChatBot in Development.";
                            textTimer.Start();
                            break;
                        case 2:
                            chatBoxText = "One day, I will hopefully become an AI.";
                            textTimer.Start();
                            break;
                        case 3:
                            chatBoxText = "I'm glad we have met. Let us begin...";
                            textTimer.Start();
                            break;
                        case 4:
                            chatBoxText = "First, tell me your name. Type it into the small Text Box.";
                            textTimer.Start();
                            inIntro = false;
                            break;
                        case 7:
                            inIntro = false;
                            break;
                    }
                }

            }
        }
        public void StartIntro()
        {
            textTimer.Tick += new EventHandler(TextEventHandler);
            textTimer.Interval = 50;
            textPause.Tick += new EventHandler(PauseEventHandler);
            textPause.Interval = 1000;
            chatBoxText = "Hello there human. ";
            introText = 0;
            textTimer.Start();
        }
        public void NameSubmit()
        {
            if (introText == 5 && Form1.form.simpleTextBox.TextLength > 0 && Form1.form.chatBox.TextLength == 0)
            {
                username = Form1.form.simpleTextBox.Text.ToString();
                Form1.form.usernameLabel.Text = "Your Name: " + username;
                Form1.form.simpleTextBox.Clear();
                chatBoxText = "Hello " + username + "! Now, who am I? Tell me in the textbox.";
                textTimer.Start();
            }
            if (introText == 6 && Form1.form.simpleTextBox.TextLength > 0 && Form1.form.chatBox.TextLength == 0)
            {
                botname = Form1.form.simpleTextBox.Text.ToString();
                Form1.form.Name = botname;
                Form1.form.botNameLabel.Text = botname;
                Form1.form.simpleTextBox.Clear();
                chatBoxText = "So my name is " + botname + "? What a wonderful name! Thank you, " + username + "! Now we can have wonderful conversations! " + username + " and " + botname + ", the best of friends!";
                textTimer.Start();
            }
        }

    }
}