using System;

public class Person : Character
{

  public Person() {

    icon = 'P';
  }
  
  public void Move(Direction d) {
        
    int x = Position.x;
    int y = Position.y;

    switch(d) {
      case Direction.Up:
        Position = new Coords(x, ++y);
        break;
      case Direction.Down:
        Position = new Coords(x, --y);
        break;
      case Direction.Left:
        Position = new Coords(--x, y);
        break;
      case Direction.Right:
        Position = new Coords(++x, y);
        break;
    }
  }

    public void Jump() => Console.WriteLine("Person Jump!");
}

