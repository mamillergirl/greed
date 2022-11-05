using Raylib_cs;
using System.Numerics;

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
class ColoredObject: GameObject {
    public Color Color { get; set; }

    public ColoredObject(Color color) {
        Color = color;
    }
}

class DaddyRock: ColoredObject {
    public int Size { get; set; }
    public int Points = -50;

    public DaddyRock(Color color, int size): base(color) {
        Size = size;
    }

    override public void Draw() {
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, Size, Size, Color);
    }    }

class MiddleRock: ColoredObject {
    public int Size { get; set; }
    public int Points = -25;

    public MiddleRock(Color color, int size): base(color) {
        Size = size;
    }

    override public void Draw() {
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, Size, Size, Color);
    }   
}

class BabyRock: ColoredObject {
    public int Size { get; set; }
    public int Points = -5;

    public BabyRock(Color color, int size): base(color) {
        Size = size;
    }

    override public void Draw() {
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, Size, Size, Color);
    }   
}
class Gem: ColoredObject {
    public int Size { get; set; }
    public int Points = 25;

    public Gem(Color color, int size): base(color) {
        Size = size;
    }

    override public void Draw() {
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, Size, Size, Color);
    }   
}


