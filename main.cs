using System;
using System.Collections.Generic;

class MainClass {

  public static void Main (string[] args) {
    
    Game g = new Game();
    g.Start();
  }

  private class Game {

    public void Start() {

      // Create input controllers
      AnalogController aCon = new AnalogController();
      DigitalController dCon = new DigitalController();
      MotionController mCon = new MotionController();

      // Create characters
      Person person = new Person();
      Vehicle vechicle = new Vehicle();
      //Swarm swarm = new Swarm();
          
      TestManager t = new TestManager(aCon, dCon, mCon);
      t.DoTest(person);
      t.DoTest(vechicle);
      //t.DoTest(swarm);
    }
  }
}