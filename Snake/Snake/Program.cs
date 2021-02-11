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
            bool o = true, b= true;
            Console.Write("Введите ширину игрового поля от 10-80 w: ");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину игрового поля от 10-25 h: ");
            int h = Convert.ToInt32(Console.ReadLine());
            while (o && b) {
                if ((w<10) || (w> 80)){
                    Console.Write("Ширина не в диапазоне от 10 до 80 введите ещё раз w: ");
                    w = Convert.ToInt32(Console.ReadLine());
                }
                else{
                    o = false;
                }if((h < 10) || (h > 25)){
                    Console.Write("Высота не в диапазоне от 10 до 25 введите ещё раз h: ");
                    h = Convert.ToInt32(Console.ReadLine());
                }
                else{
                    b = false;
                }

            }
            Console.Clear();
            Wall walls = new Wall(w, h);
            walls.Drowi();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drowi();

            FoodCreator foodcreator = new FoodCreator(w, h, '$');
            Point food = foodcreator.CreateFood();
            food.Drowi();

            while (true) {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ВЫ ПРОИГРАЛИ !");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Нажмите что бы закончить");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }

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
