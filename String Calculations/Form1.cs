using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Calculations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string count = richTextBox1.Text; //sets string count to the input of richtextbox
            char[] characterCount; //creates a character array for Character Count 
            characterCount = count.ToCharArray(); //converts a string to an character array 

            int spaceCounter = 0; //sets counters as integers 
            int wordCount = 0; //Sets the WordCount at 0 so that it restarts the counter at zero everytime 
            int characterC = 0;

            wordCount = count.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length; //removes the empy spaces form the count, split, 
                                                                                                        //splits the strings into sub strings based on the characters
                                                                                                        // Not including empty array elements 
            for (int i = 0; i < characterCount.Length; i++)                                             //puts in chracters into an array with the option of removing spaces
            {
                if (char.IsWhiteSpace(characterCount[i]))            //counts spaces and chracters
                {                                                    //if character is a white space and if not it automatically counts it as a character
                    spaceCounter++;                                  //Looks for spaces
                }
                else
                {
                    characterC++;
                }
            }

            string inputstrings = richTextBox1.Text; //sets the inputstring as what you are typing into the rich text box 
            string outputStrings = string.Empty; //this tests whether or not the string is null or has a set value 
            while (inputstrings.Length > 0) //the string length will always be greater than 0 as long as you have something typed in
            {
                int incroment = 0; //set the incroment counter at 0 everytime it restarts 

                for (int i = 0; i < inputstrings.Length; i++)           //while input text then it instalizes the for loop
                {                                                       //i is an incrementing variable 
                    if (inputstrings[0] == inputstrings[i])
                    {                                                   //while statement counts how many times a letter comes up and incroments it by 1 
                        incroment++; //the ++ incroments it by one each time 
                    }
                }
                outputStrings += " " + inputstrings[0] + "=" + incroment + " "; //+= adds everything after the = sign and incroments
                inputstrings = inputstrings.Replace(inputstrings[0].ToString(), string.Empty); 
            }

            alphabet.Text = outputStrings;                          
            wordCounttxt.Text = " " + wordCount.ToString(); //sets labels to each count variables 
            characterCounttxt.Text = " " + characterC.ToString();
            spaceCounttxt.Text = spaceCounter.ToString();
        }
    }
}
