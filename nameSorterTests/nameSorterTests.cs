using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nameSorter.Tests
{
    [TestClass()]
    public class nameSorterTests
    {
        //test method for provided unsorted-names-list.txt file
        [TestMethod()]
        public void providedFileTest()
        {
            //create an array of expected output for provided unsorted-names-list.txt file
            string[] expectedOutput = { "Marin Alvarez",
                                       "Adonis Julius Archer",
                                       "Beau Tristan Bentley",  
                                       "Hunter Uriah Mathew Clarke",
                                       "Leo Gardner",
                                       "Vaughn Lewis",
                                       "London Lindsey",
                                       "Mikayla Lopez",
                                       "Janet Parsons",
                                       "Frankie Conner Ritter",
                                       "Shelby Nathan Yoder"
            };

            //actual output after sorting names for provided unsorted-names-list.txt file
            string[] actualOutput = nameSorter.sortNames(@"C:\\Users\\DHRUVA\\Desktop\\nameSorter\\nameSorter\\testFiles\\unsorted-names-list.txt");
            //check weather expeted output and actual output is equal or not
            CollectionAssert.AreEqual(expectedOutput,actualOutput);
        }

        //test method for .txt file with same last name
        [TestMethod()]
        public void sameLastNameTest()
        {
            //create an array of expected output for provided samelastname.txt file
            string[] expectedOutput = { "Alok Sudhirbhai Dhruva",
                                       "Ankur Dipakbhai Dhruva",
                                       "Darpan Hirenbhai Dhruva",
                                       "Milap Kaushikbhai Dhruva",
                                       "Samkit Rajendrabhai Dhruva"
            };

            //actual output after sorting names for provided samelastname.txt file
            string[] actualOutput = nameSorter.sortNames(@"C:\\Users\\DHRUVA\\Desktop\\nameSorter\\nameSorter\\testFiles\\samelastname.txt");
            //check weather expeted output and actual output is equal or not
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }

        //test method for .txt file with same first name
        [TestMethod()]
        public void sameFirstNameTest()
        {
            //create an array of expected output for provided sameFirstName.txt file
            string[] expectedOutput = { "Darshit Anilbhai Dhruva",
                                       "Darshit Mansukhbhai Dhruva",
                                       "Darshit Shirishkumar Jasani",
                                       "Darshit Atulbhai Parekh"
            };

            //actual output after sorting names for provided sameFirstName.txt file
            string[] actualOutput = nameSorter.sortNames(@"C:\\Users\\DHRUVA\\Desktop\\nameSorter\\nameSorter\\testFiles\\sameFirstName.txt");
            //check weather expeted output and actual output is equal or not
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }

        //test method for .txt file with same last name and same given name
        [TestMethod()]
        public void sameLastGivenNameTest()
        {
            //create an array of expected output for provided sameLastGivenName.txt file
            string[] expectedOutput = { "Alok Sudhirbhai Dhruva",
                                       "Ankur Dipakbhai Dhruva",
                                       "Darpan Atulbhai Dhruva",
                                       "Darpan Hirenbhai Dhruva",
                                       "Darpan Rajendrabhai Dhruva",
                                       "Milap Kaushikbhai Dhruva",
                                       "Samkit Rajendrabhai Dhruva"
            };

            //actual output after sorting names for provided sameLastGivenName.txt file
            string[] actualOutput = nameSorter.sortNames(@"C:\\Users\\DHRUVA\\Desktop\\nameSorter\\nameSorter\\testFiles\\sameLastGivenName.txt");
            //check weather expeted output and actual output is equal or not
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }

        //test method for must have at least 1 given name and may have upto 3 given names
        [TestMethod()]
        public void validNameTest()
        {
            //create an array of expected output for provided validName.txt file
            string[] expectedOutput = {"Keyur Giteshkumar Dave",
                                       "Alok Sudhirbhai Dhruva",
                                       "Ankur Dipakbhai Dhruva",
                                       "Darpan Atulbhai Dhruva",
                                       "Darpan Hirenbhai Dhruva",
                                       "Darpan Rajendrabhai Dhruva",
                                       "Milap Kaushikbhai Dhruva",
                                       "Samkit Rajendrabhai Dhruva"
            };

            //actual output after sorting names for provided validName.txt file
            string[] actualOutput = nameSorter.sortNames(@"C:\\Users\\DHRUVA\\Desktop\\nameSorter\\nameSorter\\testFiles\\validName.txt");
            //check weather expeted output and actual output is equal or not
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }
    }
}