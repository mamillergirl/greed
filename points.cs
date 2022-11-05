using Raylib_cs;
using System.Numerics;

class Points{
    Rectangle player = new Rectangle();
    DaddyRock rock1 = new DaddyRock();
    MiddleRock rock2 = new MiddleRock();
    BabyRock rock3 = new BabyRock();
    Gem gem1 = new Gem();

    public void checkCollisions(){
    Raylib.DrawText($"Points: {TotalPoints}", 12, 460, 20, Color.WHITE);
      int TotalPoints = 300;
      if (Raylib.CheckCollisionRecs(Rectangle, DaddyRock)){
          TotalPoints += rock1.Points;
      }
      if (Raylib.CheckCollisionRecs(Rectangle, MiddleRock)){
          TotalPoints += rock2.Points;
      }
      if (Raylib.CheckCollisionRecs(Rectangle, BabyRock)){
          TotalPoints += rock3.Points;
      }
      if (Raylib.CheckCollisionRecs(Rectangle, Gem)){
          TotalPoints += gem1.Points;
      }
  }
  }