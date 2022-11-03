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
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                // Add a new random object to the screen every iteration of our game loop
                var whichType = Random.Next(3);

                // Generate a random velocity for this object
                var randomY = Random.Next(-2, 2);
                var randomX = Random.Next(-2, 2);

                // Each object will start about the center of the screen
                var position = new Vector2(ScreenWidth / 2, ScreenHeight / 2);

                switch (whichType) {
                    case 0:
                        //daddy rock
                        var square = new GameSquare(Color.RED, 15);
                        square.Position = position;
                        square.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(square);
                        break;
                    case 1:
                        //middle rock
                        var square = new GameSquare(Color.YELLOW, 10);
                        square.Position = position;
                        square.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(square);
                        break;
                    case 2:
                        //baby rock
                        var square = new GameSquare(Color.GREEN, 5);
                        square.Position = position;
                        square.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(square);
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