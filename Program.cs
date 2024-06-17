using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//    Завдання 2:
//Створіть додаток «Англо-французький словник», який має
//зберігати наступну інформацію:
// слово англійською мовою;
// варіанти перекладу французькою.
//Для зберігання інформації використовуйте Dictionary<T>.
//Додаток має надавати таку функціональність:
// додати слово і варіанти перекладу;
// видалити слово;
//видалити варіанти перекладу;
// зміна слова;
// зміна варіанта перекладу;
// пошук перекладу слова.
namespace hw_24_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary dictionaryApp = new MyDictionary();

            
            dictionaryApp.addWord("hello", new List<string> { "bonjour", "salut" });
            dictionaryApp.addWord("goodbye", new List<string> { "au revoir", "adieu" });
            dictionaryApp.addWord("pink", new List<string> {"lepurde" });


            


            dictionaryApp.changeTransaltion("hello", "salut", "coucou");


            dictionaryApp.searchTranslation("hello");
            dictionaryApp.searchTranslation("goodbye");
            dictionaryApp.searchTranslation("pink");


            dictionaryApp.removeTranslater("hello", "bonjour");
            dictionaryApp.changeWord("goodbye", "farewell");

            dictionaryApp.removeWord("farewell");
        }
    }
}
