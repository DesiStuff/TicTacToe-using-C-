using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player 1 enter your initial: ");
            String player1 = Console.ReadLine();
            Console.WriteLine("Player 2 enter your initial: ");
            String player2 = Console.ReadLine();
            //game(player1,player2);
            gamewitharray();
         
            
            void game(string player1, string player2)
            {
                string MM = "*";
                string ML = "*";
                string MR = "*";
                string TM = "*";
                string TL = "*";
                string TR = "*";
                string BM = "*";
                string BL = "*";
                string BR = "*";
                int p = 1;
                int box = 0;
                int count = 1;
                int ifrun = 1;
                while(count < 10)
                {
                    Console.WriteLine($"{TL}|{TM}|{TR}");
                    Console.WriteLine($"{ML}|{MM}|{MR}");
                    Console.WriteLine($"{BL}|{BM}|{BR}");
                    
                    if (p == 1)
                    {
                        Console.WriteLine(" P1 Select your box: MM, ML, MR, TM, TL, TR, BM, BL, BR");
                        box = 1;
                        ifrun = 1;
                    }
                    else
                    {
                        Console.WriteLine(" P2 Select your box: MM, ML, MR, TM, TL, TR, BM, BL, BR");
                        box = 2;
                        ifrun = 1;
                    }


                    string inp = Console.ReadLine();
                    if (inp == "MM")
                    {
                        if (MM == "*")
                        {
                            count++;
                            if (box == 1)
                                MM = player1;
                            else
                                MM = player2;
                        }
                        else
                        {
                            Console.WriteLine("Box already marked, please select the box again");
                            ifrun = 0;
                        }
                    }
                    else if (inp == "ML")
                    {
                        if (ML == "*")
                        {
                            count++;
                            if (box == 1)
                                ML = player1;
                            else
                                ML = player2;
                        }
                        else
                        {
                            Console.WriteLine("Box already marked, please select the box again");
                            ifrun = 0;
                        }

                    }
                    else if (inp == "MR")
                    {
                        if (MR == "*")
                        {
                            count++;
                            if (box == 1)
                                MR = player1;
                            else
                                MR = player2;
                        }
                        else
                        {
                            Console.WriteLine("Box already marked, please select the box again");
                            ifrun = 0;
                        }
                    }
                    else if (inp == "TM")
                    {
                        if (TM == "*")
                        {
                            count++;
                            if (box == 1)
                                TM = player1;
                            else
                                TM = player2;
                        }
                        else
                        {
                            Console.WriteLine("Box already marked, please select the box again");
                            ifrun = 0;
                        }
                    }
                    else if (inp == "TR")
                    {
                        if (TR == "*")
                        {
                            count++;
                            if (box == 1)
                                TR = player1;
                            else
                                TR = player2;
                        }
                        else
                        {
                            Console.WriteLine("Box already marked, please select the box again");
                            ifrun = 0;
                        }
                    }
                    else if (inp == "TL")
                    {
                        if (TL == "*")
                        {
                            count++;
                            if (box == 1)
                                TL = player1;
                            else
                                TL = player2;
                        }
                        else
                        {
                            Console.WriteLine("Box already marked, please select the box again");
                            ifrun = 0;
                        }
                    }
                    else if (inp == "BM")
                    {
                        if (BM == "*")
                        {
                            count++;
                            if (box == 1)
                                BM = player1;
                            else
                                BM = player2;
                        }
                        else
                        {
                            Console.WriteLine("Box already marked, please select the box again");
                            ifrun = 0;
                        }
                    }
                    else if (inp == "BL")
                    {
                        if (BL == "*")
                        {
                            count++;
                            if (box == 1)
                                BL = player1;
                            else
                                BL = player2;
                        }
                        else
                        {
                            Console.WriteLine("Box already marked, please select the box again");
                            ifrun = 0;
                        }
                    }
                    else if (inp == "BR")
                    {
                        if (BR == "*")
                        {
                            count++;
                            if (box == 1)
                                BR = player1;
                            else
                                BR = player2;
                        }
                        else
                        {
                            Console.WriteLine("Box already marked, please select the box again");
                            ifrun = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("WARNING: Please select the correct box!!!");
                        ifrun = 0;
                    }
                    if (ifrun == 1)
                    {
                        if (box == 1)
                        {
                            p = 2;
                            box = 2;
                        }
                        else
                        {
                            p = 1;
                            box = 1;
                        }
                    }

                    if (count > 9)
                    {
                        Console.WriteLine($"{TL}|{TM}|{TR}");
                        Console.WriteLine($"{ML}|{MM}|{MR}");
                        Console.WriteLine($"{BL}|{BM}|{BR}");
                    }

                    if (MM == player1 && ML == player1 && MR == player1)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 1: {player1}");
                        break;

                    }
                    if (MM == player2 && ML == player2 && MR == player2)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 2: {player2}");
                        break;

                    }
                    if (TM == player1 && TL == player1 && TR == player1)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 1: {player1}");
                        break;
                    }
                    if (TM == player2 && TL == player2 && TR == player2)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 2: {player2}");
                        break;
                    }
                    if (BM == player1 && BL == player1 && BR == player1)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 1: {player1}");
                        break;
                    }
                    if (BM == player2 && BL == player2 && BR == player2)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 2: {player2}");
                        break;
                    }
                    if (TL == player1 && ML == player1 && BL == player1)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 1: {player1}");
                        break;
                    }
                    if (TL == player2 && ML == player2 && BL == player2)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 2: {player2}");
                        break;
                    }
                    if (TM == player1 && MM == player1 && BM == player1)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 1: {player1}");
                        break;
                    }
                    if (TM == player2 && MM == player2 && BM == player2)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 2: {player2}");
                        break;
                    }
                    if (TR == player1 && MR == player1 && BR == player1)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 1: {player1}");
                        break;
                    }
                    if (TR == player2 && MR == player2 && BR == player2)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 2: {player2}");
                        break;
                    }
                    if (TL == player1 && MM == player1 && BR == player1)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 1: {player1}");
                        break;
                    }
                    if (TL == player2 && MM == player2 && BR == player2)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 2: {player2}");
                        break;
                    }
                    if (TR == player1 && MM == player1 && BL == player1)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 1: {player1}");
                        break;
                    }
                    if (TR == player2 && MM == player2 && BL == player2)
                    {
                        Console.WriteLine($"YAY!!! YOU WON, Player 2: {player2}");
                        break;
                    }
                    //return 0;
                    
                }
            }

            void gamewitharray()
            {
                string[,] array2D = new string[3, 3];
                for(int i = 0; i<3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        array2D[i, j] = ("*");
                    }
                }
                    
            }
        }
    }
}
