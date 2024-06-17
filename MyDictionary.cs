using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_24_06
{
    internal class MyDictionary
    {
        private Dictionary<string, Translater> _dictionary;

        public MyDictionary()
        {
            _dictionary = new Dictionary<string, Translater>();
        }

        public void addWord(string englishWord, List<string> frenchTranslate)
        {
            _dictionary[englishWord] = new Translater(englishWord, frenchTranslate);
        }

        public void removeWord(string englishWord)
        {
            _dictionary.Remove(englishWord);
        }

        public void removeTranslater(string englishWord, string frenchTranslater)
        {
            if (_dictionary.ContainsKey(englishWord))
            {
                _dictionary[englishWord].removeTranslate(frenchTranslater);
            }
        }

        public void changeWord(string oldEnglishWord, string newEnglishWord)
        {
            if (_dictionary.ContainsKey(oldEnglishWord))
            {
                var entry = _dictionary[oldEnglishWord];
                _dictionary.Remove(oldEnglishWord);
                entry.EnglishWord = newEnglishWord;
                _dictionary[newEnglishWord] = entry;
            }
        }


        public void changeTransaltion(string englishWord, string oldFrenchWord, string newFrenchTransaltion)
        {
            if (_dictionary.ContainsKey(englishWord))
            {
                _dictionary[englishWord].changeTranslate(oldFrenchWord, newFrenchTransaltion);
            }
        }



        public void searchTranslation(string englishWord)
        {
            if (_dictionary.ContainsKey(englishWord))
            {
                Console.WriteLine(_dictionary[englishWord]);
            }
            else
            {
                Console.WriteLine($"The word '{englishWord}' is not in the dictionary.");
            }
        }
    }
}
