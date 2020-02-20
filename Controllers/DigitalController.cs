using System;

public class DigitalController
{
  public event EventHandler<GamePadArgs> GamePadEvt;
  public event EventHandler<DigitalButtonArgs> ButtonAEvt;
  public event EventHandler<DigitalButtonArgs> ButtonBEvt;

  public void OnGamePad(Direction d) {
    
    GamePadArgs args = new GamePadArgs(d);
    GamePadEvt?.Invoke(this, args);
  }

  public void OnButtonA(bool isPressed) {

    DigitalButtonArgs args = new DigitalButtonArgs(isPressed);
    ButtonAEvt?.Invoke(this, args);
  }

  public void OnButtonB(bool isPressed) {

    DigitalButtonArgs args = new DigitalButtonArgs(isPressed);
    ButtonBEvt?.Invoke(this, args);
  }
}
