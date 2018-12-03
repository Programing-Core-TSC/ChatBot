//Still pretty new to C#, but the idea is that this script is for analyzing a user's message and replying.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class SpeechHandler
    {
        string UserMessage;
        string BotReply;
        int emotion;
        double neutralWords;
        double happyWords;
        double sadWords;
        double angryWords;
        double calmWords;
        double totalWords;
        bool aboutBot = false;
        //Okay, since I'm using an int to save emotions, I'm going to need a table for values to emotion.
        //Neutral ---- 0
        //Happy ---- 1
        //Sad ---- 2
        //Angry ---- 3
        //Calm ---- 4


        public int EmotionResponse()
        {
            UserMessage = Form1.form.userChatBox.Text;
            string[] messageWords = UserMessage.Split(' '); //Turns large string from user and breaks it down into words.

            foreach (var word in messageWords) //Checks each word to see if it's most likely a more positive statement, negative statement, or other.
            {
                if(word == "happy" || word == "great" || word == "fun" || word == "fantastic" || word == "cool" || word == "cute" || word == "awesome" || word == "amazing")
                {
                    happyWords++;
                    totalWords++;
                }
                if(word == "sad" || word == "terrible" || word == "bad" || word == "boring" || word == "cry")
                {
                    sadWords++;
                    totalWords++;
                }
                if(word == "stupid" || word == "furious" || word == "angry" || word == "mad" || word == "dumb" || word == "kill" || word == "death" || word == "dead")
                {
                    angryWords++;
                    totalWords++;
                }
                if(word == "chill" || word == "relax" || word == "relaxing" || word == "relaxed" || word == "calm" || word == "peaceful")
                {
                    calmWords++;
                    totalWords++;
                }
                if(word == "you" || word == "yourself")
                {
                    aboutBot = true;
                    neutralWords++;
                    totalWords++;
                }
                else
                {
                    neutralWords++;
                    totalWords++;
                }
            }
            var happyPercent = happyWords/totalWords;
            Form1.form.test.Text = happyWords.ToString();

            if (emotion == 1) //Happy Reaction
            {
                return 1;
            }
            else if (emotion == 2) //Sad Reaction
            {
                return 2;
            }
            else if (emotion == 3) //Angry Reaction
            {
                return 3;
            }
            else if (emotion == 4) //Calm Reaction
            {
                return 4;
            }
            else //Neutral Reaction - Used if no other reaction is similar.
            {
                return 0;
            }
        }

    }
}
