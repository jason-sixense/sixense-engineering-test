using System;

public struct Coords : IEquatable<Coords>
{
    public int x;
    public int y;

    public Coords(int p1, int p2)
    {
        x = p1;
        y = p2;
    }

    public bool Equals(Coords otherCoords)
      => otherCoords.x == x && otherCoords.y == y;
}

public struct TestOutput : IEquatable<TestOutput>
{
    public char icon;
    public Coords coords;

    public TestOutput(char icon, Coords coords)
    {
        this.coords = coords;
        this.icon = icon;
    }

  public bool Equals(TestOutput otherOutput)
    => otherOutput.icon == icon && coords.Equals(otherOutput.coords);
}
