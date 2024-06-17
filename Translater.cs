using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_24_06
{
    internal class Translater
    {
        public string EnglishWord {  get; set; }
        public List<string> FrenchTranslate { get; set; }

        //public Translater(List<string> french)
        //{
        //    FrenchTranslate = french;
        //}
        public Translater(string english, List<string> french) 
        { 
            EnglishWord = english;
            FrenchTranslate = french;
        }

        public void addTranslate(string translate)
        {
            FrenchTranslate.Add(translate);
        }

        public void removeTranslate(string translate) 
        {
            FrenchTranslate.Remove(translate);
        }

        public void changeTranslate(string oldTranslate, string newTranslate)
        {
            int index = FrenchTranslate.IndexOf(oldTranslate);
            if (index >= 0)
            {
                FrenchTranslate[index] = newTranslate;
            }
            else
            {
                Console.WriteLine($"Translation '{oldTranslate}' not found for '{EnglishWord}'.");
            }
        }
        public override string ToString()
        {
            return $"{EnglishWord}: {string.Join(", ", FrenchTranslate)}";
        }
    }
}
