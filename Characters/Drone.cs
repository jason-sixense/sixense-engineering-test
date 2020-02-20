using System;

public class Drone : Character
{

  public Drone() {

    icon = 'D';
  }
  //
  // Input range from -0.5 to 0.5
  //
  public void Fly(float[] pos) {

    if (Math.Abs(pos[0]) > 0.5f || Math.Abs(pos[1]) > 0.5f)
    {
        throw new System.ArgumentException("Drone movement out of range!");
    }

    string horz = pos[0] < 0 ? "Left" : pos[0] > 0 ? "Right" : "";
    string vert = pos[1] < 0 ? "Down" : pos[1] > 0 ? "Up" : ""; 
    
    Console.WriteLine("-----Drone-----");
    if (pos[0] != 0)
      Console.WriteLine(horz + " : " + Math.Abs(pos[0]));
    if (pos[1] != 0)
      Console.WriteLine(vert + " : " + Math.Abs(pos[1]));
    Console.WriteLine("--------------");
    }
}



