using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Week7
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";

            CheckFile(out userInput);
            
            ReadFile(userInput);

            CountFile(userInput);

            Console.WriteLine("Program will close now. Have a nice day.");

            
        }

        

        public static void CheckFile(out string userInput)
        {


            Console.WriteLine("Please enter a file path: ");
            userInput = Console.ReadLine();

            string pattern = @"^[A-z]:\W[A-Z,a-z]{1,9}\W[a-zA-Z0-9](?:[a-zA-Z0-9 ._-]*[a-zA-Z0-9])\D{1,9}?[a-z,0-9]{1,9}.+$";

            Match m = Regex.Match(userInput, pattern, RegexOptions.IgnoreCase);
            if (m.Success)
            {

                Console.WriteLine("File path verified. Opening file...");
            
            }
            else
            {
                 
                Console.WriteLine("Invalid file path. Please try again.");
                CheckFile(out userInput);
            }
            

           

            




        }

       


        public static void ReadFile(string userInput)
        {
            try
            {
                StreamReader sr = new StreamReader(userInput);

                
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }
        }
        public static void CountFile(string userInput)
        {
            try
            {
                string filePath = userInput;
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File does not exist :{0} ", filePath);
                    return;
                }

                string[] textFromFile = File.ReadAllLines(filePath);
                foreach (string line in textFromFile)
                {
                    Console.WriteLine(line);
                }
                var count = File.ReadAllText(userInput).Split(' ').Count();

                Console.WriteLine("There are " + count + " words in the file specified.");
            }
            catch (Exception e)
            {
                Console.WriteLine("There was a problem with the program execution." + e.Message);

            }
        }
    }



}        

      

       
        
    
        

