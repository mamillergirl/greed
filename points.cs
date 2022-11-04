using Raylib_cs;
using System.Numerics;

class Points{
    PlayerShape player = new PlayerShape;   
    DaddyRock rock1 = new DaddyRock;
    MiddleRock rock2 = new MiddleRock;
    BabyRock rock3 = new BabyRock;
    Gem gem1 = new Gems; 

  while(!Raylib.WindowShouldClose()){
      int TotalPoints = 300;
      if (Raylib.CheckCollisionRecs(player, rock1)){
          TotalPoints += rock1.Points;
      }
      if (Raylib.CheckCollisionRecs(player, rock2)){
          TotalPoints += rock2.Points;
      }
      if (Raylib.CheckCollisionRecs(player, rock3)){
          TotalPoints += rock3.Points;
      }
      if (Raylib.CheckCollisionRecs(player, GEM)){
          TotalPoints += gem1.Points;
      }
      Raylib.DrawText($"{TotalPoints}")
  }
  }