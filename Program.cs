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
            var Objects = new List<CollectibleObject>();
            var Random = new Random();
            var RectangleSize = 10;
            int TotalPoints = 300;

            var PlayerRectangle = new Rectangle(ScreenWidth / 2, ScreenHeight -RectangleSize, RectangleSize, RectangleSize);
            var MovementSpeed = 4;

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "GameObject");
            Raylib.SetTargetFPS(50);

            while (!Raylib.WindowShouldClose())
            {
                // Add a new random object to the screen every iteration of our game loop
                //List<int> numbers = new List<int>()
                //{
                //    0,1, 1, 1 ,1,2, 2, 2, 2, 2,3, 3, 3, 3, 3, 3, 3,4, 4, 4,5,6,7,8,9,10
                //};
                //int randIndex = Random.Next(numbers.Count);
                //var whichType = numbers[randIndex];
                var whichType = Random.Next(30);
                // Generate a random velocity for this object
                var randomY = Random.Next(1, 2);
                var randomX = 0;
                var randomXstart = Random.Next(ScreenWidth);

                // Each object will start about the center of the screen
                var position = new Vector2(randomXstart, 0);

                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                    PlayerRectangle.x += MovementSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                    PlayerRectangle.x -= MovementSpeed;
                }
                
                switch (whichType) {
                    case 0:
                        
                        var daddyRock = new DaddyRock(Color.RED, 30);
                        daddyRock.Position = position;
                        daddyRock.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(daddyRock);
                        break;
                    case 1:
                        
                        var middleRock = new MiddleRock(Color.YELLOW, 20);
                        middleRock.Position = position;
                        middleRock.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(middleRock);
                        break;
                    case 2:
                        var babyRock = new BabyRock(Color.ORANGE, 50);
                        babyRock.Position = position;
                        babyRock.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(babyRock);
                        break;
                    case 3:
                        var gem = new Gem(Color.BLUE, 20);
                        gem.Position = position;
                        gem.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(gem);
                        break;
                    default:
                        break;
                }


                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawRectangleRec(PlayerRectangle, Color.PINK);
             



        
               
       
                Raylib.DrawText($"Points: {TotalPoints}", 12, ScreenHeight - 30, 20, Color.WHITE);
                // Draw all of the objects in their current location
                foreach (var obj in Objects) {
                    obj.Draw();
                    
                    
                }

                Raylib.EndDrawing();

                // Move all of the objects to their next location
                foreach (var obj in Objects) {
                    obj.Move();
                }
                foreach (var obj in Objects.ToList()){

                    var rectangle = new Rectangle(obj.Position.X, obj.Position.Y, 20, 20);

                    if (Raylib.CheckCollisionRecs(PlayerRectangle, rectangle)) {
                    TotalPoints += obj.Points;
                    Objects.Remove(obj);}
                
                }
            }

            Raylib.CloseWindow();
        }
    }
}