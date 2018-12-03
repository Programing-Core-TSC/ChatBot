/* Summery
Okay, I'm not even gonna lie. This code is a mess. It needs to be optimized when possible.
This program is a chatbot, but the final goal is to get it to learn over time. An AI of sorts.
I'd like it to go through three stages of development, as follows.
1.) The Chatbot, something to proccess information. Very simple, but nice.
2.) Give it a litte personality, preferably stylized like SCP-079, The Old AI.
3.) Possibly give it a way to synthesize speech? It'd be a cool concept
For the moment, things have a long way to go. That's all.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _introHandler = new IntroHandler();
            _speechHandler = new SpeechHandler();
            form = this;
        }
        internal static Form1 form;

        private IntroHandler _introHandler;
        private SpeechHandler _speechHandler;
        int submits = 0;


        private void chatBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _introHandler.StartIntro();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void simpleTextButton_Click(object sender, EventArgs e)
        {
            _introHandler.NameSubmit();
        }

        private void userChatButton_Click(object sender, EventArgs e)
        {
            if (_introHandler.inIntro == false)
            {
                submits++;
                submitCount.Text = submits.ToString();
                _speechHandler.EmotionResponse();
            }
        }
    }
}
