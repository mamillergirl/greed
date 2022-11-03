using Raylib_cs;
using System.Numerics;
// class DaddyRock{
//     public Vector2 Position { get; set; } = new Vector2(0, 0);
//     public Vector2 Velocity { get; set; } = new Vector2(0, 0);

//     virtual public void Draw() {
//         // Base game objects do not have anything to draw
//     }

//     public void Move() {
//         Vector2 NewPosition = Position;
//         NewPosition.X += Velocity.X;
//         NewPosition.X += Velocity.X;
//         Position = NewPosition;
//     }
//     public Color Color { get; set; }

//     public DaddyRock(Color color) {
//         Color = color;

//     } 
//     public int points = -50
// }

// public class MiddleRock: DaddyRock{
// // the median points
//     int points =-25
//      public int Size { get; set; }

//     public MiddleRock(Color color, int size): base(color) {
//         Size = size;
//     }

//     override public void Draw() {
//         DrawText((int)Position.X, (int)Position.Y, Size, Size, Color);
//     }
// }

// public class BabyRock: MiddleRock{
// // the least points
//     int points =-5
// }



class GameObject {
    public Vector2 Position { get; set; } = new Vector2(0, 0);
    public Vector2 Velocity { get; set; } = new Vector2(0, 0);

    virtual public void Draw() {
        // Base game objects do not have anything to draw
    }

    public void Move() {
        Vector2 NewPosition = Position;
        NewPosition.X += Velocity.X;
        NewPosition.Y += Velocity.Y;
        Position = NewPosition;
    }
}



class DaddyRock: GameObject {

    override public void Draw(){
    Raylib.DrawText("🗿", 12, 12, 30, Color.RED);
    }
}

class MiddleRock: GameObject {

    override public void Draw(){
    Raylib.DrawText("🪨", 12, 12, 20, Color.YELLOW);
    }
}

class BabyRock: GameObject {

    override public void Draw(){
    Raylib.DrawText("🚼", 12, 12, 15, Color.GREEN);
    }
}
