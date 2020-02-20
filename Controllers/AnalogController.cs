using System;

public class AnalogController
{
  public event EventHandler<AnalogStickArgs> AnalogStickEvt;
  public event EventHandler<AnalogButtonArgs> ButtonAEvt;
  public event EventHandler<AnalogButtonArgs> ButtonBEvt;

  public void OnAnalogStick(float x, float y) {

    AnalogStickArgs args = new AnalogStickArgs(x, y);
    AnalogStickEvt?.Invoke(this, args);
  }

  public void OnButtonA(bool isPressed) {

    AnalogButtonArgs args = new AnalogButtonArgs(isPressed);
    ButtonAEvt?.Invoke(this, args);
  }

  public void OnButtonB(bool isPressed) {

    AnalogButtonArgs args = new AnalogButtonArgs(isPressed);
    ButtonBEvt?.Invoke(this, args);
  }
}
