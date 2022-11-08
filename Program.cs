using System.IO;
using System.Text.RegularExpressions;

namespace HomeWork_09
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            string searchResult = "Incorrect input";
            string[] baza = LoadPhoneBook();
            string searchBar = GetSearchBar();

            if (searchBar != "")
            {
                searchResult = FindASubscriber(searchBar, baza);
            }
            Console.WriteLine("search result: " + searchResult);
        }

        static string[] LoadPhoneBook()
        {
            string[] phoneBook = { "Clara Klane +380670356345", "li Lion +380340356745", "Clara Frog +380478356745" };
            return phoneBook;
        }

        static string GetSearchBar()
        {
            
            Console.WriteLine($"Enter search string:");
            string searchBar = Console.ReadLine();
            
            return searchBar;

        }

        static string FindASubscriber(string param, string[] data)
        {
            
            string result = "The subscriber is not in the phone book.";
            string[] columnNames = { "name", "surname", "tel" };

            for (int i = 0; i < data.Length; i++)
            {
                Boolean regexResult = Regex.IsMatch(data[i], param, RegexOptions.IgnoreCase);
                if (regexResult)
                {
                    result = data[i];
                }
            }
            
            return result;

        }
    }
}