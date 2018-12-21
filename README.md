# ChatBot
###### A simple ChatBot project in C#. Created by a Sophomore in High School.
Current Version: v0.1.4


ChatBot is, like the name implies, a simple chat bot program written in C#. It is a project created with the idea to make a program to interpret statements from a user without using a Microsoft Azure API. The project went nicely for a while, but eventually some buggy antivirus software prevented proper development locally and the project was uploaded to GitHub for storage.

This project should now have a Webhook in my discord server.

### Documentation
ChatBot is meant to break down sentences sent by users into individual works to analyze. Then, after analysis, the program will choose an appropriate response from a list of pre-generated ones and reply to the user. It isn't too accurate, but that's due to it being early in development. Currently, the bot is not properly functional due to errors from antivirus, leading to a halt on development for the moment. 

ChatBot handles emotions by scanning each word to see if it is classified as a particular emotion, and if it does, it adds one to a counter centered around that emotion. Once the entire statement has been analyzed, it divides every emotion category by the total amount of words, and responds with a statement from the emotion with the highest percentage. 

The following words are classified as Happy Words:
* happy
* great
* fun
* fantastic
* cool
* cute
* awesome
* amazing

The following words are classified as Sad Words:
* sad
* terrible
* bad
* boring
* cry

The following words are classified as Angry Words:
* stupid
* furious
* angry
* mad
* dumb
* kill
* death
* dead

The following words are classified as Calm Words:
* chill
* relax
* relaxing
* relaxed
* calm
* peaceful

All other words are classified as Neutral Words. 

THIS PROGRAM IS CURRENTLY BROKEN. ONCE I HAVE TIME AND A FUNCTIONAL WORKSTATION, I WILL FIX IT.

Thank you for reading this. Enjoy your day.

~Programing-Core-TSC
