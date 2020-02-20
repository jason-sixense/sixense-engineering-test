using System;

public class MotionController
{
  public event EventHandler<WiiArgs> WiiEvt;
  public event EventHandler<AnalogButtonArgs> ButtonAEvt;

  public void OnWii(float yaw, float roll, float pitch) {

    WiiArgs args = new WiiArgs(yaw, roll, pitch);

    EventHandler<WiiArgs> handler = WiiEvt;
    if (handler != null)
    {
      handler(this, args);
    }
  }

    public void OnButtonA(bool isPressed) {

        AnalogButtonArgs args = new AnalogButtonArgs(isPressed);
        ButtonAEvt?.Invoke(this, args);
    }
}
