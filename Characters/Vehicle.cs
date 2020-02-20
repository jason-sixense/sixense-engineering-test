using System;

public class Vehicle : Character {

    public Vehicle() {

        icon = 'V';
    }

    public void Move(float[] pos) {

        if (Math.Abs(pos[0]) > 1.0f || Math.Abs(pos[1]) > 1.0f) {
            throw new System.ArgumentException("Vehicle movement out of range!");
        }

        int horz = 0;
        int vert = 0;
        if (pos[0] != 0)
            horz = pos[0] > 0 ? 1 : -1;
        if (pos[1] != 0)
            vert = pos[1] > 0 ? 1 : -1;

        int x = Position.x;
        int y = Position.y;

        Position = new Coords(x + horz, y + vert);
    }

    public void Jump() => Console.WriteLine("Vehicle Jump!");
}
