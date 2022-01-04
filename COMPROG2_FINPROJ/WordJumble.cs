using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPROG2_FINPROJ_DRAWY;


namespace COMPROG2_FINPROJ_DRAWY
{
    class WordJumble
    {
       
        public string ScrambleWord(string word)
        {
            char[] chars = new char[word.Length];
            Random rand = new Random(10000);
            int index = 0;
            while (word.Length > 0)
            { // Get a random number between 0 and the length of the word. 
                int next = rand.Next(0, word.Length - 1); // Take the character from the random position 
                                                          //and add to our char array. 
                chars[index] = word[next];                // Remove the character from the word. 
                word = word.Substring(0, next) + word.Substring(next + 1);
                ++index;
            }
            return new String(chars);
            
        }

        internal void ScrambleWord(object scramWord)
        {
            throw new NotImplementedException();
        }

        /*public void selectWord()
        {
            string path = @"Word Database.txt";

            Random rand = new Random();
            string[] ReadWord = File.ReadAllLines(path);

            WordJumble w = new WordJumble();
            string selectedWord = ReadWord[rand.Next(0, ReadWord.Length)];

            string JWord1 = selectedWord;
            string JWord2 = w.ScrambleWord(JWord1);
            jumbledLetter.Text = JWord2;
        }*/



        
    }


}
