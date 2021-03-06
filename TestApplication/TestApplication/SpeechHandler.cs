﻿//Still pretty new to C#, but the idea is that this script is for analyzing a user's message and replying.
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
        //Unknown ---- 5

        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= '0' && str[i] <= '9') || (str[i] >= 'A' && str[i] <= 'z' || str[i] == ' '))
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString();
        }


        public int EmotionResponse()
        {
            neutralWords = 0.000;
            happyWords = 0.000;
            sadWords = 0.000;
            angryWords = 0.000;
            calmWords = 0.000;
            totalWords = 0.000;

            UserMessage = Form1.form.userChatBox.Text;
            RemoveSpecialCharacters(UserMessage);
            UserMessage.ToLower();
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
            var sadPercent = sadWords/totalWords;
            var angryPercent = angryWords/totalWords;
            var calmPercent = calmWords/totalWords;
            var neutralPercent = neutralWords/totalWords;

            

            if (happyPercent > sadPercent && happyPercent > angryPercent && happyPercent > calmPercent && happyPercent > neutralPercent) //Happy Reaction
            {
                return 1;
            }
            else if (sadPercent > happyPercent && sadPercent > angryPercent && sadPercent > calmPercent && sadPercent > neutralPercent) //Sad Reaction
            {
                return 2;
            }
            else if (angryPercent > happyPercent && angryPercent > sadPercent && angryPercent > calmPercent && angryPercent > neutralPercent) //Angry Reaction
            {
                return 3;
            }
            else if (calmPercent > happyPercent && calmPercent > sadPercent && calmPercent > angryPercent && calmPercent > neutralPercent) //Calm Reaction
            {
                return 4;
            }
            else if (neutralPercent > happyPercent && neutralPercent > sadPercent && neutralPercent > angryPercent && neutralPercent > calmPercent) //Neutral Reaction
            {
                return 0;
            }
            else
            {
                return 5;
            }
        }

    }
}
