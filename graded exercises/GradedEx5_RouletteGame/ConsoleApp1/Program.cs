using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            Roulettegame();


        }

        public static void Roulettegame()
        {




            Random rd = new Random();
            int r = rd.Next(1, 37);


            Console.WriteLine("Welcome to Fundazgo Casino. You are about to play the Roulette game. You have several betting options." +
                "For Red/Black bet press 1, For Odd/Even bet press 2, For High/Low press 3, For Columns press 4, For dozens" +
                "press 5, For Straight up press 6, For split press 7, For street press 8, For Corner press 9, For Line Press 10, To quit enter 0.");
            int x = int.Parse(Console.ReadLine());

            do{
                switch (x)
                {
                    case 1:
                        Console.WriteLine("You have chosen Red/Black bet. " +
                            "If you want to bet on Red. choose 1, if black choose 2. ");
                        int redorblack = int.Parse(Console.ReadLine());


                        switch (redorblack)
                        {
                            case 1:

                                Console.WriteLine("How much money do you want to bet. Please type a whole number.");
                                int betmoney = int.Parse(Console.ReadLine());
                                Console.WriteLine("The roulette ball landed on the number " + r);
                                Console.ReadLine();

                                int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
                                if (r == red[0] || r == red[1] || r == red[2] || r == red[3] || r == red[4] || r == red[5]
                                        || r == red[6] || r == red[7] || r == red[8] || r == red[9] || r == red[10] || r == red[11])
                                {
                                    Console.WriteLine("You bet on Red. The random number that landed on the wheel" + r + " " +
                                       "is a red number. Thereby you win even amount. You will be getting back $ " + betmoney + ".");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, the ball landed on a black number. You lost!");
                                    Console.ReadLine();
                                }

                                break;


                            case 2:


                                Console.WriteLine("How much money do you want to bet. Please type a whole number.");
                                int blackbetmoney = int.Parse(Console.ReadLine());
                                int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
                                if (r == black[0] || r == black[1] || r == black[2] || r == black[3] || r == black[4] || r == black[5]
                                        || r == black[6] || r == black[7] || r == black[8] || r == black[9] || r == black[10] || r == black[11])
                                {
                                    Console.WriteLine("You bet on Black. The random number that landed on the wheel " + r + " " +
                                       "is a black number. Thereby you win even amount. You will be getting back $ " + blackbetmoney + ".");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, the ball landed on a red number. You lost!");
                                    Console.ReadLine();
                                }

                                break;


                        }


                        break;

                    case 2:
                        Console.WriteLine(" You have chosen to place the odd/even bet. " +
                            "For odd Please press 1. For even press 2");
                        int oddeven = int.Parse(Console.ReadLine());

                        switch (oddeven)
                        {
                            case 1:
                                Console.WriteLine("You have decided to bet on the odd numbers." +
                                    "How much money do you want to bet? Please enter a whole number");
                                int oemoney = int.Parse(Console.ReadLine());

                                if (r % 2 == 1)
                                {
                                    Console.WriteLine("The ball landed on" + " " + r + ". Which is an odd number. Since you" +
                                      " bet on odd numbers you win even amount of $" + " " + oemoney + ".  You will be" +
                                      "  getting $" + 2 * oemoney + " Congratulations!!!");
                                    Console.ReadLine();
                                }

                                else
                                {
                                    Console.WriteLine("You bet on odd numbers. However the ball landed on" + r + ".Which is" +
                                      " an even number. Thereby, you lose. We are sorry.");
                                    Console.ReadLine();
                                }

                                break;

                            case 2:
                                Console.WriteLine("You have decided to bet on even numbers." +
                                    "How much money do you want to bet? Please enter a whole number");
                                int oeomoney1 = int.Parse(Console.ReadLine());

                                if (r % 2 != 1)
                                {
                                    Console.WriteLine("The ball landed on" + " " + r + ". Which is an even number. Since you" +
                                      " bet on even numbers you won even amount of money equaling to $" + " " + oeomoney1 + ". You will be" +
                                      "  getting $" + 2 * oeomoney1 + " Congratulations!!!");
                                    Console.ReadLine();
                                }

                                else
                                {
                                    Console.WriteLine("You bet on even numbers. However the ball landed on" + r + ".Which is" +
                                      " an odd number. Thereby, you lose. We are sorry.");
                                    Console.ReadLine();
                                }


                                break;






                        }



                        break;

                    case 3:
                        Console.WriteLine("You have chosen the high or low option. " +
                            "If you want to choose the high option press 1. For the low option press 2.");
                        int highlow = int.Parse(Console.ReadLine());

                        switch (highlow)
                        {
                            case 1:

                                Console.WriteLine("Please enter the amount you want to bet.");
                                int highlowmoney = int.Parse(Console.ReadLine());

                                if (r >= 18 && r <= 36)
                                {
                                    Console.WriteLine(" You bet on the high option and the ball landed on" + " " + r + ".Which falls within the high " +
                                        "value of 18-36. Thereby you win even amount of $" + highlowmoney + ".The total amount you get " +
                                        "is $" + 2 * highlowmoney + " Congratulations!!!!"); Console.ReadLine();
                                }

                                else
                                {
                                    Console.WriteLine("Sorry! the ball landed on" + " " + r + ". It did not fall between 18 and 36. We are sorry but you lost");
                                    Console.ReadLine();
                                }

                                break;

                            case 2:

                                Console.WriteLine("Please enter the amount you want to bet.");
                                int highlowmoney1 = int.Parse(Console.ReadLine());

                                if (r >= 1 && r <= 18)
                                {
                                    Console.WriteLine(" You bet on the low option and the ball landed on" + " " + r + ".Which falls within the high " +
                                        "value of 1-18. Thereby you win even amount of $" + highlowmoney1 + ".The total amount you get " +
                                        "is $" + 2 * highlowmoney1 + " Congratulations!!!!"); Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Sorry! the ball landed on" + " " + r + ". It did not fall between 1 and 18." +
                                        " We are sorry but you lost"); Console.ReadLine();
                                }




                                break;




                        }




                        break;

                    case 4:

                        Console.WriteLine("You have chosen column bet. For the first column press 1. For the second column" +
                            "press 2 and for the third column press 3.");
                        int columnbet = int.Parse(Console.ReadLine());

                        switch (columnbet)
                        {
                            case 1:
                                Console.WriteLine("Please enter the amount of money you wish to bet: ");
                                int columnmoney = int.Parse(Console.ReadLine());

                                int[] columnone = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };

                                int i = 0;

                                for (i = 0; i < 13; i++)
                                {

                                    if (columnone[i] == r)
                                    {
                                        Console.WriteLine("You chose to bet on column one. The randomly generated number is"
                                          + " " + r + " which falls in column one. You have won twice the amount of what you bet"
                                          + " $" + 2 * columnmoney + ". In total you get $" + columnmoney * 3 + ". Congratulations!!!");
                                        Console.ReadLine();
                                    }


                                    else if (i == 12 && columnone[i] != r)

                                    {
                                        Console.WriteLine(" The randomly generated number is " + r + ". It does not fall in column two. Thereby," +
                                    "You have lost.");
                                        Console.ReadLine();

                                    }


                                }





                                break;


                            case 2:

                                Console.WriteLine("Please enter the amount of money you wish to bet: ");
                                int columnmoneytwo = int.Parse(Console.ReadLine());

                                int[] columntwo = { 2, 5, 8, 11, 14, 17, 19, 20, 23, 26, 29, 32, 35 };

                                int itwo = 0;

                                for (itwo = 0; itwo < 13; itwo++)
                                {

                                    if (columntwo[itwo] == r)
                                    {

                                        Console.WriteLine("You chose to bet on column two. The randomly generated number is"
                                          + " " + r + " which falls in column two. You have won twice the amount of what you bet"
                                          + " $" + 2 * columnmoneytwo + ". In total you get $" + columnmoneytwo * 3 + ". Congratulations!!!");
                                        Console.ReadLine();
                                    }


                                    else if (itwo == 12 && columntwo[itwo] != r)

                                    {
                                        Console.WriteLine(" The randomly generated number is " + r + ". It does not fall in column two. Thereby," +
                                    "You have lost.");
                                        Console.ReadLine();

                                    }

                                }







                                break;


                            case 3:

                                Console.WriteLine("Please enter the amount of money you wish to bet: ");
                                int columnmoneythree = int.Parse(Console.ReadLine());

                                int[] columnthree = { 2, 5, 8, 11, 14, 17, 19, 20, 23, 26, 29, 32, 35 };

                                int ithree = 0;

                                for (ithree = 0; ithree < 13; ithree++)
                                {

                                    if (columnthree[ithree] == r)
                                    {
                                        Console.WriteLine("You chose to bet on column two. The randomly generated number is"
                                          + " " + r + " which falls in column two. You have won twice the amount of what you bet"
                                          + " $" + 2 * columnmoneythree + ". In total you get $" + columnmoneythree * 3 + ". Congratulations!!!");
                                        Console.ReadLine();

                                    }

                                    else if (ithree == 12 && columnthree[ithree] != r)

                                    {
                                        Console.WriteLine(" The randomly generated number is " + r + ". It does not fall in column two. Thereby," +
                                    "You have lost.");
                                        Console.ReadLine();

                                    }

                                }



                                break;







                        }

                        break;

                    case 5:


                        Console.WriteLine(" You have chosen to bet on dozens. For the first dozen press 1. " +
                            "For second dozen press 2. For third dozen press 3.");
                        int dozen = int.Parse(Console.ReadLine());

                        switch (dozen)
                        {
                            case 1:
                                Console.WriteLine("Please enter the amount of dollars you weant to bet: ");
                                int betdozenone = int.Parse(Console.ReadLine());

                                int[] dozenone = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                                int idozenone = 0;

                                for (idozenone = 0; idozenone < 12; idozenone++)
                                {

                                    if (dozenone[idozenone] == r)
                                    {
                                        Console.WriteLine("You chose to bet on the first dozen. The randomly generated number is"
                                          + " " + r + " which falls in the first dozen. You have won twice the amount of what you bet"
                                          + " $" + 2 * betdozenone + ". In total you get $" + betdozenone * 3 + ". Congratulations!!!");
                                        Console.ReadLine();

                                    }

                                    else if (idozenone == 11 && dozenone[idozenone] != r)

                                    {
                                        Console.WriteLine(" The randomly generated number is " + r + ". It does not fall in first dozen. Thereby," +
                                    "You have lost.");
                                        Console.ReadLine();

                                    }

                                }



                                break;

                            case 2:


                                Console.WriteLine("Please enter the amount of dollars you weant to bet: ");
                                int betdozentwo = int.Parse(Console.ReadLine());

                                int[] dozentwo = { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
                                int idozentwo = 0;

                                for (idozentwo = 0; idozentwo < 12; idozentwo++)
                                {

                                    if (dozentwo[idozentwo] == r)
                                    {
                                        Console.WriteLine("You chose to bet on the second dozen. The randomly generated number is"
                                          + " " + r + " which falls in the second dozen. You have won twice the amount of what you bet"
                                          + " $" + 2 * betdozentwo + ". In total you get $" + betdozentwo * 3 + ". Congratulations!!!");
                                        Console.ReadLine();

                                    }

                                    else if (idozentwo == 11 && dozentwo[idozentwo] != r)

                                    {
                                        Console.WriteLine(" The randomly generated number is " + r + ". It does not fall in the second dozen. Thereby," +
                                    "You have lost.");
                                        Console.ReadLine();

                                    }



                                }

                                break;

                            case 3:
                                Console.WriteLine("Please enter the amount of dollars you weant to bet: ");
                                int betdozenthree = int.Parse(Console.ReadLine());

                                int[] dozenthree = { 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
                                int idozenthree = 0;

                                for (idozenthree = 0; idozenthree < 12; idozenthree++)
                                {

                                    if (dozenthree[idozenthree] == r)
                                    {
                                        Console.WriteLine("You chose to bet on the third dozen. The randomly generated number is"
                                          + " " + r + " which falls in the third dozen. You have won twice the amount of what you bet"
                                          + " $" + 2 * betdozenthree + ". In total you get $" + betdozenthree * 3 + ". Congratulations!!!");
                                        Console.ReadLine();

                                    }

                                    else if (idozenthree == 11 && dozenthree[idozenthree] != r)

                                    {
                                        Console.WriteLine(" The randomly generated number is " + r + ". It does not fall in the third dozen. Thereby," +
                                    "You have lost.");
                                        Console.ReadLine();

                                    }



                                }





                                break;










                        }

                        break;

                    case 6:
                        Console.WriteLine("You have chosen the straight up option. Please enter the amount you want to bet: ");
                        int straightupmoney = int.Parse(Console.ReadLine());
                        Console.WriteLine("Chose a number out of 1 to 36: ");
                        int straightup = int.Parse(Console.ReadLine());

                        if (straightup == r)
                        {
                            Console.WriteLine("The randomly generated number is" + " " + r +
                              ". Which is also the number you chose. Thereby you win 35 to 1 pay out, which is $" +

                              35 * straightupmoney + ".You get a total of $" + 36 * straightupmoney + ". Congratulations!!!!");
                            Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine("The ball landed on" + " " + r + ".Which is not what you chose. Thereby, you have lost!");
                            Console.ReadLine();
                        }


                        break;

                    case 7:
                        Console.WriteLine("You have chosen the split option. Please enter the amount you want to bet: ");
                        int splitmoney = int.Parse(Console.ReadLine());


                        Console.WriteLine("Please choose two adjacent numbers");
                        Console.ReadLine();
                        Console.WriteLine("Please enter the firstnumber: ");
                        int splitfirst = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the secondnumber");
                        int splitsecond = int.Parse(Console.ReadLine());



                        if (r == splitfirst)
                        {
                            Console.WriteLine("Since one of the numbers you chose in the splitbet is equal to" + " " + r + ". You have won 17 folds of" +
                              "what you bet, $" + 17 * splitmoney + ". Thereby, you get a total of" + " " + 18 * splitmoney + ".");
                            Console.ReadLine();
                        }

                        else if (r == splitsecond)
                        {
                            Console.WriteLine("Since one of the numbers you chose in the splitbet is equal to" + " " + r + ". You have won 17 folds of" +
                                "what you bet, $" + 17 * splitmoney + ". Thereby, you get a total of" + " " + 18 * splitmoney + ".");
                            Console.ReadLine();
                        }

                        else if (r != splitfirst && r != splitsecond)
                        {
                            Console.WriteLine(" The ball did not land on neither of the numbers of split bet. Thereby you have lost");
                        }






                        break;

                    case 8:
                        Console.WriteLine("You have chosen the street bet option. Please enter the amount you want to bet: ");
                        int streetbetmoney = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter the first number of the row you want to place the street bet on: ");
                        int streetbeti = int.Parse(Console.ReadLine());
                        int streetbetii = streetbeti + 1;
                        int streetbetiii = streetbeti = 2;

                        if (r == streetbeti || r == streetbetii || r == streetbetiii
                            )
                        {
                            Console.WriteLine("The ball landed on" + " " + r + ".Which falls on the row you chose for the street bet. " +
                              "Thereby you win 11 folds which is $"
                              + 11 * streetbetmoney + ". The total amount you get is" + " $" + 12 * streetbetmoney + ".");
                            Console.ReadLine();
                        }



                        else
                        {
                            Console.WriteLine("The ball did not lie on the row you chose. The ball landed on " + r + " You lost, we are sorry!");
                            Console.ReadLine();
                        }



                        break;

                    case 9:

                        Console.WriteLine("You have chosen to place the corner bet. Please enter the amount of money you want to bet: ");
                        int cornerbetmoney = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter the first number: ");
                        int xone = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the second number: ");
                        int yone = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the third number: ");
                        int zone = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the fourth number: ");
                        int uone = int.Parse(Console.ReadLine());

                        int[] cornerbet = { xone, yone, zone, uone };



                        int ione = 0;


                        for (ione = 0; ione < 4; ione++)
                        {
                            if (cornerbet[ione] == r)
                            {
                                Console.WriteLine("The ball landed on " + r + "which falls on your corner bet. You have won 8 folds of what you bet, which is $"
                                    + 8 * cornerbetmoney + ". You" +
                                    "get a total of $" + 9 * cornerbetmoney + ".Congratulations!!!");
                                Console.ReadLine();

                            }
                            else if (cornerbet[ione] != r && ione == 3)
                            {
                                Console.WriteLine("Sorry, the ball did not land on your corner. It landed on " + r + " You have lost.");
                                Console.ReadLine();
                            }


                        }




                        break;

                    case 10:
                        { 

                        Console.WriteLine("You have chosen to bet on the Line. Please enter the amount you want to bet: ");
                        int linebet = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter the first digit of the first row for the Line bet: ");
                        int firstrow = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter the first digit of the second row for the Line bet: ");
                        int Secondrow = int.Parse(Console.ReadLine());

                        int[] Linebetarray = { firstrow, firstrow + 1, firstrow + 2, Secondrow, Secondrow + 1, Secondrow + 2 };

                        int iLinebetarray = 0;

                            for (iLinebetarray = 0; iLinebetarray < 6; iLinebetarray++)
                            {
                                if (Linebetarray[iLinebetarray] == r)

                                {
                                    Console.WriteLine("You have wont. The ball landed on " + " " + r + "which falls on the line you bet on." +
                                      "You win 6 folds of what you bet, which will be $" + " " + 6 * linebet +
                                      ".Thereby you get a total of $" + 7 * linebet + ".Congratulations!!!!");
                                    Console.ReadLine();
                                }





                                else if (Linebetarray[iLinebetarray] != r && iLinebetarray == 5)

                                {
                                    Console.WriteLine("The ball landed on" + " " + r + "." +
                                      " It did not fall on the line you bet. We are sorry that you lost!!!");
                                }


                            }



                            break;


























                        }

                }
                Console.WriteLine("Would you like to place another bet? You have several betting options." +
                "For Red/Black bet press 1, For Odd/Even bet press 2, For High/Low press 3, For Columns press 4, For dozens" +
                "press 5, For Straight up press 6, For split press 7, For street press 8, For Corner press 9, For Line Press 10, For Basket press 11" +
                "For snake bet press 12. To quit enter 0");
                 x = int.Parse(Console.ReadLine());

            } while (x != 0) ;


            

        } 
            
    }
}