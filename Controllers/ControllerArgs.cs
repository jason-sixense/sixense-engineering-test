using System;

public enum Direction {
  Up,
  Down,
  Left,
  Right
}

public class GamePadArgs : EventArgs {

  public GamePadArgs (Direction d) {

    D = d;
  }

  public Direction D {get; private set;}
}

public class AnalogStickArgs : EventArgs {

  public AnalogStickArgs(float x, float y) {

    X = Utils.Clamp(x, -1, 1);
    Y = Utils.Clamp(y, -1, 1);
  }

  public float X {get; private set;}
  public float Y {get; private set;}
}

public class DigitalButtonArgs : EventArgs {

  public DigitalButtonArgs(bool isPressed) {
  
    IsPressed = isPressed;
  }

  public bool IsPressed {get; private set;}
}

public class AnalogButtonArgs : EventArgs {

  public AnalogButtonArgs(bool buttonValue) {

    ButtonValue = buttonValue ? 1.0f : -1.0f;
  }

  public float ButtonValue { get; private set; }
}

public class WiiArgs : EventArgs {

  public WiiArgs(float yaw, float roll, float pitch) {

    Yaw = Utils.Clamp(yaw, -180, 180);
    Roll = Utils.Clamp(roll, -180, 180);
    Pitch = Utils.Clamp(pitch, -90, 90);
  }

  public float Yaw {get; private set;}
  public float Roll {get; private set;}
  public float Pitch {get; private set;}
}
