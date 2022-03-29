using System;
using System.Collections.Generic;
using System.Text;
namespace Hangman
{
    class Game
    {
        public int life { get; set; }
        public string word;
        private StringBuilder guessedLetters;
        public char[] reaveler;
        private bool win = false;
        private bool gameover = false;
        public Game(string word)
        {
            this.life = 10;
            this.word = word;
            this.reaveler = new char[(word.Length )];
            int id = 0;
            foreach(char letter in this.reaveler)
            {
                this.reaveler[id] = '_';
                id++;
            }
            this.guessedLetters = new StringBuilder();
        }
        public bool guessChar(char letter)
        {
            if (guessedLetters.ToString().Contains(letter))
            {
                return false;
            }
            bool found = false;
            if (word.Contains(letter))
            {
                int id = 0;
                foreach (char c in word)
                {
                    if(c == letter && this.reaveler[id] != letter)
                    {
                        this.reaveler[id] = letter;
                        found = true;
                    }
                    id++;
                }

            }
            else
            {
                life--;
            }
            guessedLetters.Append(letter);
            this.checkIfWin();
            return found;
        }
        public bool guessWord(string word)
        {
            if(word.ToLower() == this.word.ToLower())
            {
                gameover = true;
                win = true;
                return true;
            }
            else
            {
                life--;
                return false;
            }
        }
        private void checkIfWin()
        {
            if (life == 0)
            {
                gameover = true;
            }
            string toCheck = new string(this.reaveler);
            bool isExist = toCheck.Contains('_');
            if (!isExist)
            {
                gameover = true;
                win = true;
            }
        }
        public bool getWin()
        {
            return this.win;
        }
        public int getLife()
        {
            return this.life;
        }
        public bool getGameover()
        {
            return this.gameover;
        }
    }
}
