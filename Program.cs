using Raylib_cs;
using System.Numerics;

namespace HelloWorld
{
    static class Program
    {
        public static void Main()
        {

            var ScreenHeight = 480;
            var ScreenWidth = 800;
            var Objects = new List<GameObject>();
            var Random = new Random();

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "GameObject");
            Raylib.SetTargetFPS(20);

            while (!Raylib.WindowShouldClose())
            {
                // Add a new random object to the screen every iteration of our game loop
                List<int> numbers = new List<int>()
                {
                    0,1, 1, 1 ,1,2, 2, 2, 2, 2,3, 3, 3, 3, 3, 3, 3,4, 4, 4,5,6,7,8,9,10
                };
                int randIndex = Random.Next(numbers.Count);
                var whichType = numbers[randIndex];

                // Generate a random velocity for this object
                var randomY = Random.Next(0, 2);
                var randomX = Random.Next(0, 2);
                var randomXstart = Random.Next(ScreenWidth);

                // Each object will start about the center of the screen
                var position = new Vector2(randomXstart, 0);

                switch (whichType) {
                    case 0:
                        Console.WriteLine("Creating a square");
                        var daddyRock = new DaddyRock(Color.RED, 30);
                        daddyRock.Position = position;
                        daddyRock.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(daddyRock);
                        break;
                    case 1:
                        Console.WriteLine("Creating a circle");
                        var middleRock = new MiddleRock(Color.YELLOW, 20);
                        middleRock.Position = position;
                        middleRock.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(middleRock);
                        break;
                    case 2:
                        var babyRock = new BabyRock(Color.GREEN, 30);
                        babyRock.Position = position;
                        babyRock.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(babyRock);
                        break;
                    case 3:
                        var gem = new Gem(Color.GOLD, 20);
                        gem.Position = position;
                        gem.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(gem);
                        break;
                    default:
                        break;
                }


                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                // Draw all of the objects in their current location
                foreach (var obj in Objects) {
                    obj.Draw();
                }

                Raylib.EndDrawing();

                // Move all of the objects to their next location
                foreach (var obj in Objects) {
                    obj.Move();
                }
            }

            Raylib.CloseWindow();
        }
    }
}

