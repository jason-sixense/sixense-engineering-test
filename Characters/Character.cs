using System;

public class Character
{

    protected char icon;
    public char Icon {
        get { return icon; }
    } 
  
    public Coords Position { get; set; } = new Coords(0, 0);

    public void Reset() {

        Position = new Coords(0, 0);
    }

}