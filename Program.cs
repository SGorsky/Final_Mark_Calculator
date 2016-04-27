using System;
using System.Collections.Generic;
using System.Linq;

namespace Final_Mark_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Final Mark Calculator v1.2.3 by Sean Gorsky";

            #region Instructions
            /*
            Console.Write("Would you like to read the instructions? Y/N\n");
            string yesOrNo = Console.ReadLine().ToLower();

            if (yesOrNo == "y")
            {
                while (yesOrNo == "y")
                {
                    Console.Clear();
                    Console.Write("It is useful to use this application near the end of your course when you\nalready know " +
                        "all your marks and you only have your exam left to write.\n" +
                        "Lets say you have a course ABC 101 and you are graded based on 4 items.\n" +
                        "A midterm worth 20%: You recieved a mark of 70%\n" +
                        "Another midterm worth 20%: You recieved a mark of 83%\n" +
                        "An assignment worth 30%: You recieved a mark of 80%\n" +
                        "And an exam worth 30%\n\nYou would enter the marks like so...\n\nPress Enter to continue...");
                    Console.ReadLine();

                    Console.Clear();
                    Console.Write("How many items are you being evaluated on? 4\n\nPress Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();

                    Console.Write("Mark Weight (out of 100%): 20\nMark (out of 100%): 70\n\nPress Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();

                    Console.Write("Mark Weight (out of 100%): 20\nMark (out of 100%): 76\n\nPress Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();

                    Console.Write("Mark Weight (out of 100%): 30\nMark (out of 100%): 80\n\nPress Enter to continue...");
                    Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("And thats it! Would you like to reread the instructions? Y/N");
                    yesOrNo = Console.ReadLine().ToLower();
                }
            }
            */
            #endregion

            Console.Clear();
            Console.Write("How many items are you being evaluated on? ");
            byte numItems = Convert.ToByte(Console.ReadLine());

            List<Evaluation> evaluationList = new List<Evaluation>();

            for (int i = 0; i < numItems - 1; ++i)
            {
                Console.Clear();

                Console.Write("Mark Weight (out of 100%): ");
                float itemWeight = Convert.ToSingle(Console.ReadLine());

                Console.Write("Mark (out of 100%): ");
                float itemMark = Convert.ToSingle(Console.ReadLine());

                evaluationList.Add(new Evaluation(itemMark, itemWeight));
            }

            float examWeight = 100 - evaluationList.Sum(e => e.Weight);
            Console.Clear();

            Console.Clear();

            Console.Write("Exam Weight (out of 100%): " + examWeight + "%\n\n");

            for (int i = 0; i <= 100; i += 5)
            {
                Console.WriteLine("Exam Mark: " + i + "%\tFinal Mark: " + (evaluationList.Sum(e => e.GradeMark) + i * examWeight / 100 ) + "%");
            }

            Console.Write("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}