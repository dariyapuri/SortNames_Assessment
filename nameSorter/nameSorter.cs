using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace nameSorter
{
    public class nameSorter
    {
        //This method will return a sorted names in array
        public static string[] sortNames(string fileName)
        {
            // read the .txt file with names
            string[] lines = System.IO.File.ReadAllLines(fileName);

            //create a list of all names
            var listNames = new List<string>();

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                int a = 0;
                int myWord = 1;
                //get number of words in each name
                while (a <= line.Length - 1)
                {
                    if (line[a] == ' ' || line[a] == '\n' || line[a] == '\t')
                    {
                        myWord++;
                    }
                    a++;
                }

                // A name must have at least 1 given name and may have upto 3 given names
                if (myWord >= 2 && myWord < 5)
                {
                    listNames.Add(line);
                }

            }

            //sort the list of names according to first name 
            listNames.Sort();

            //sort the list of names according to last name
            IEnumerable<string> sortedNames = from person in listNames.Cast<string>()
                                              let lastName = person.Split(' ').Last()
                                              orderby lastName ascending
                                              select person;
            return sortedNames.ToArray();
        }

        //Main Method
        public static void Main(string[] args)
        {
            // Pass the unsorted file path from the sortNames method
            try
            {
                var sortedNames = sortNames(@"C:\\Users\\DHRUVA\\Desktop\\nameSorter\\nameSorter\\unsorted-names-list.txt");
                //Pass the file path and file name to the StreamReader constructor
                StreamWriter sw = new StreamWriter(@"C:\\Users\\DHRUVA\\Desktop\\nameSorter\\nameSorter\\sorted-names-list.txt");


                // write the sorted names in a .txt file and print sorted list of names to screen
                foreach (var name in sortedNames)
                {
                    if (name != null)
                    {
                        sw.WriteLine(name);
                        Console.WriteLine(name);
                    }
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }   
            Console.WriteLine("\n\nPress Any key to exit the progran");
            Console.ReadKey();
        }   
    }
}


