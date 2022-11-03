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
            var Objects = new List<rockobjects>();
            var Random = new Random();

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "rockobjects");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                // Add a new random object to the screen every iteration of our game loop
                var rocks = Random.Next(3);

                // Generate a random velocity for this object
                var randomY = Random.Next(-1, 1);
                var randomX = Random.Next(-1, 1);
                var randomXStart = Random.Next(ScreenWidth);

                // Each object will start about the center of the screen
                var position = new Vector2(randomXStart, 0);

                switch (rocks) {
                    case 0:
                        //daddy rock
                        var rock = new DaddyRock();
                        rock.Position = position;
                        rock.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(rock);
                        break;
                    case 1:
                        //middle rock
                        var rock = new MiddleRock();
                        rock.Position = position;
                        rock.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(rock);
                        break;
                    case 2:
                        //baby rock
                        var rock = new BabyRock();
                        rock.Position = position;
                        rock.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(rock);
                        break;
                    default:
                        break;
                }


                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

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