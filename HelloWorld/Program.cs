using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
      
        /// <summary>
        /// The code asks a question and gets the answer from the user
        /// </summary>
        /// <param name="question">the question to ask</param>
        /// <param name="answer">the correct answer expected</param>
        /// <returns>If they got it right or not</returns>
        static bool AskQuestion(string question,string answer)
        {
            Console.WriteLine(question);
            var v1 = Console.ReadLine();
            if (v1.ToUpper() == answer.ToUpper())
            {
                Console.WriteLine("Correct!");
                return true;
            }
            else
            {
                Console.WriteLine("Wrong! It's " + answer);
                return false;
            }
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //bool correct = AskQuestion("What is your name?", "Sir Galahad");
            //while(!correct)
            //{
            //    correct = AskQuestion("What is your name?", "Sir Galahad");
            //}

            Random rand = new Random();
            int dicethrow = rand.Next(1, 6);
            for (int i=0;i < 10; i-=1)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
                

            //AskQuestion("What is your quest?", "To seek the holy grail");
            //AskQuestion("What is the air speed velocity of an unladened swallow?", "African or european");

        }

        
    }
}
