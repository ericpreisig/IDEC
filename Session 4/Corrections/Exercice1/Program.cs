using System;

namespace Exercice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quel élément de la liste voulez-vous afficher ? : ");

            try
            {
                string userEntry = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(userEntry))
                {
                    DisplayAll();
                }
                else
                {
                    int index = int.Parse(userEntry);
                    Display(index);
                }
            }
            catch 
            {
                Console.WriteLine("Il n'y a pas d'élément à l'index définis");
            }
        }

        private static void DisplayAll()
        {
            string[] listCourses = GetListCourses();
            foreach(string element in listCourses)
            {
                Console.WriteLine(element);
            }
        }

        private static void Display(int index)
        {
            string[] listCourses = GetListCourses();
            Console.WriteLine(listCourses[index]);
        }

        private static string[] GetListCourses()
        {
            return File.ReadAllLines("../../../list.txt");
        }
    }
}