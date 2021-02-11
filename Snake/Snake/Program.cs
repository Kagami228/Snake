using System;
using System.IO;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            LineHorizontal Hl = new LineHorizontal(0,79,0,'-');
            VerticalLine Vl = new VerticalLine(1, 24, 0, '!');
            LineHorizontal Hl2 = new LineHorizontal(0, 79, 24, '-');
            VerticalLine Vl2 = new VerticalLine(1, 24, 79, '!');
            Hl.Drowi();
            Vl.Drowi();
            Vl2.Drowi();
            Hl2.Drowi();

            Point p = new Point(2, 2,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drowi();
            snake.Move();
            FoodCreator foodcreator = new FoodCreator(80, 25, '$');
            Point food = foodcreator.CreateFood();
            food.Drowi();
            while (true){
                if (snake.eat(food))
                {
                    food = foodcreator.CreateFood();
                }else{
                    snake.Move();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable){
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Snake_Move(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            //Console.ReadLine();
        }
    }
}
