/*******************************************************************/
/**                                                               **/
/**                                                               **/
/**    Student Name                :  Amin Ahmadi                 **/
/**    EMail Address               :  ahma0160@algonquinlive.com  **/
/**    Student Number              :  040993411                   **/
/**    Course Number               :  CST 8253                    **/
/**    Lab Section Number          :  011                         **/
/**    Professor Name              :  Wei Gong                    **/
/**    Assignment Name/Number/Date :  Lab 2 2021/01/28            **/
/**    Optional Comments           :                              **/
/**                                                               **/
/**                                                               **/
/*******************************************************************/



using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool moreIntegers = true;
            bool continueToPlay = true;


            while (continueToPlay)
            {
                int min = int.MaxValue;
                int max = int.MinValue;
                int num = 0;
                int sumEven = 0;
                int sumOdd = 0;
                int numOfEven = 0;
                int numOfOdd = 0;
                double averageOfEvens = 0;
                double averageOfOdds = 0;
                while (moreIntegers)
                {
                    Console.Write("Enter an Integer: ");
                    string intStr = Console.ReadLine();

                    if (intStr == "" && num != 0)
                    {
                        moreIntegers = false;
                    }

                    else if (intStr == "" && num == 0)
                    {
                        Console.WriteLine("You did Not Enter Any Integer!");
                    }

                    else
                    {
                        int anInteger = int.Parse(intStr);
                        if (max < anInteger)
                        {
                            max = anInteger;
                        }
                        if (min > anInteger)
                        {
                            min = anInteger;
                        }
                        if (anInteger % 2 == 0)
                        {
                            sumEven += anInteger;
                            numOfEven++;
                        }

                        if (anInteger % 2 != 0)
                        {
                            sumOdd += anInteger;
                            numOfOdd++;
                        }
                        if (numOfEven != 0)
                        {
                            averageOfEvens = (double)sumEven / numOfEven;
                        }
                        if (numOfOdd != 0)
                        {
                            averageOfOdds = (double) sumOdd / numOfOdd;
                        }
                        num++;

                    }


                }

                Console.WriteLine("Minimum Integer You Entered is " + min);
                Console.WriteLine("Maximum Integer You Entered is " + max);

                Console.WriteLine("Number of Even Integers You Entered is " + numOfEven);
                Console.WriteLine("Sum of Even Integers You Entered is " + sumEven);
                Console.WriteLine("Average of Even Integers You Entered is " + averageOfEvens);

                Console.WriteLine("Number of Odd Integers You Entered is  " + numOfOdd);
                Console.WriteLine("Sum of Odd Integers You Entered is " + sumOdd);
                Console.WriteLine("Average of Odd Integers You Entered is " + averageOfOdds);

                Console.Write("Play again? (Y/y) ");
                string contPlay = Console.ReadLine();
                if (contPlay == "Y" || contPlay == "y")
                {
                    moreIntegers = true;
                    continueToPlay = true;
                }
                else
                {
                    continueToPlay = false;
                    Console.WriteLine("Thanks for Playing!");
                }
            }

        }

    }

}
