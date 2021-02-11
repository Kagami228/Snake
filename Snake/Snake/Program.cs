using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            LineHorizontal Hl = new LineHorizontal(0,78,0,'+');
            VerticalLine Vl = new VerticalLine(0, 24, 0, '+');
            LineHorizontal Hl2 = new LineHorizontal(0, 78, 24, '+');
            VerticalLine Vl2 = new VerticalLine(0, 24, 78, '+');
            Hl.Drowi();
            Vl.Drowi();
            Vl2.Drowi();
            Hl2.Drowi();

            Point p = new Point(4, 5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drowi();

            FoodCreator foodcreator = new FoodCreator(80, 25, '$');
            Point food = foodcreator.CreateFood();
            food.Drowi();

            while (true){
                if (snake.Eat(food)){
                    food = foodcreator.CreateFood();
                    food.Drowi();
                }else{
                    snake.Move();
                }

                Thread.Sleep(100);
                
                if (Console.KeyAvailable){
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Snake_Move(key.Key);
                }
            }

            //Console.ReadLine();
        }
    }
}
