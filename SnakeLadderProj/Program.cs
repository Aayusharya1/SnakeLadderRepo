using System;
using System.Collections;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace SnakeLadder
{
    class Program
    {
   
        public const int no_play = 0;
        public const int snake = 1;
        public const int ladder = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snakes and ladder game.");


        }

        static int DiceRoll()
        {
            Random r = new Random();
            int dice_num = r.Next(1, 7);
            return dice_num;
        }

        static int MoveDirection(int player_position, int dice_num)
        {
            Random r = new Random();
            int move_no = r.Next(0, 3);

            switch (move_no)
            {
                case no_play:
                    break;

                case snake:
                    if (player_position > dice_num) player_position = player_position - dice_num;
                    else player_position = 0;
                    break;

                case ladder:
                    if (player_position + dice_num <= 100) player_position = player_position + dice_num;
                    break;

            }

            return player_position;

        }

        static int Score() 
        {
            int points = 0;
            int score = 0;
            while(points!=100)
            {
                int dice_num = DiceRoll();
                Console.WriteLine("number on dice " + dice_num);
                points= MoveDirection(points,dice_num);
                Console.WriteLine("points = " + points);
                score += 1;
            }

            return score;
        }
    }

}
