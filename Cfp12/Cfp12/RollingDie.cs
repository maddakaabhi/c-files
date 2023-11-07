using System;

namespace Cfp12
{
    public class RollingDie

    {
        int Position = 0;
        int c = 0;
        public void SnakeandLadder() {
            

            while (Position < 100)
            {
                Random rnd = new Random();
                int x=rnd.Next(1,7);
                int y=rnd.Next(0,3);
                c += 1;

                switch (y)
                {
                    case 0:
                        //no play
                        Console.WriteLine("no play");
                        Position = Position + 0;
                        Console.WriteLine("position: " + Position);
                        break;
                    case 1:
                        //in case of ladder
                        Console.WriteLine("Climbing a ladder");
                        Position = Position + x;
                        Console.WriteLine("position: " + Position);
                        break;
                    case 2:
                        //in case of snake
                        Console.WriteLine("bite by snake");
                        Position = Position - x;
                        Console.WriteLine("position: " + Position);
                        break;  
                }
             }



        }
        static void Main(string[] args)
        {
            RollingDie z = new RollingDie();
            z.SnakeandLadder();
            Console.WriteLine("Number of times Rolling die to win:" + z.c);


           
        }
    }
}
