﻿
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace uusmang
{
    public class uusmang
    {
        public static void Main(string[] args)
        {
            
            Console.SetWindowSize(80, 25);
            Console.Clear();
            int speed = 100;
            Dictionary<string, int>  Usersdict = new Dictionary<string, int>();
            Points pointsObject = new Points();
            Speed speedObject = new Speed();
            SnakeColor colorObject = new SnakeColor();
            string color = colorObject.ChooseColor();
            pointsObject.ReadToFile(Usersdict);
            pointsObject.ShowLeaderboard(Usersdict);
            Console.WriteLine("Write your nickname");
            string nickname = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Game start in {0}", 3-i);
                Thread.Sleep(1000);
            }
            int pointcounter = 0;
            Sounds mainmusic= new Sounds();
            _ = mainmusic.Tagaplaanis_Mangida("../../../snakemusic.mp3");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Walls walls = new Walls(80, 24);
            walls.Draw();		
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT,color);
            snake.DrowCol(color);
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood(color);
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    pointsObject.AddToDictionary(Usersdict,nickname,pointcounter);
                    pointsObject.WriteToFile(Usersdict);
                    break;
                    
                }
                if (snake.Eat(food))
                {
                    _ = mainmusic.Natukene_mangida("../../../eatsound.mp3");
                    pointcounter = pointsObject.PointsCounter(pointcounter);
                    
                    food = foodCreator.CreateFood(color);
                    food.Draw();
                }
                else
                {
                    snake.Move(color);
                }
                if (pointcounter % 5==0 && pointcounter > 0)
                {
                    if (speed!= 100-(pointcounter /5 *10))
                    {
                        speed = speedObject.Speedchange(speed);       
                    }
                    
                }
                Thread.Sleep(speed);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleeKey(key.Key);
                }
            }
        }
        

    }
}
