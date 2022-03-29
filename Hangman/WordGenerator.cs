using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class WordGenerator
    {
        private string[] easyWords = { "hello", "basic", "new", "exit", "create", "simple" };
        private string[] mediumWords = { "abruptly", "lengths", "puppy", "exit", "jazzy", "yippee" };
        private string[] hardWords = { "stronghold", "fluffiness", "espionage", "jawbreaker", "haphazard", "gnostic" };
        public string word = "";
        public WordGenerator(Difficulty difficulty)
        {

            switch (difficulty)
            {
                case Difficulty.easy:
                    this.word = RandomWord(easyWords);
                    break;
                case Difficulty.medium:
                    this.word = RandomWord(mediumWords);
                    break;
                case Difficulty.hard:
                    this.word = RandomWord(hardWords);
                    break;
            }
        }
        private string RandomWord(string[] words)
        {
            var rand = new Random();
            int index = rand.Next(0, (words.Length - 1));
            return words[index];
        }
    }
}
