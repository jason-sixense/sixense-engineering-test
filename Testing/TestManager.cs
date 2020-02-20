using System;
using System.Collections.Generic;

class TestManager {

    private Character ActiveCharacter { get; set; }
    private char activeCharacterIcon;
    private List<Action> InputCommandsList = new List<Action>();
    private List<TestOutput> ExpectedTestOutputList = new List<TestOutput>();

    // Create input controllers
    private AnalogController aCon;
    private DigitalController dCon;
    private MotionController mCon;

    public TestManager(AnalogController a, DigitalController d, MotionController m) {

        aCon = a;
        dCon = d;
        mCon = m;

        // Set up test input
        SetUpInput();
    }

    public void DoTest(Character c) {

        // Reset character position
        c.Reset();
        // Set activity
        SetActiveCharacter(c);
        // Set up expected output
        PopulateExpectedTestOutputForCharacter(c);

        // Test all controllers for character
        List<TestOutput> outputForCharacter = TestController(InputCommandsList, c);

        // Test output
        VerifyTestResults(outputForCharacter);
    }

    private List<TestOutput> TestController(List<Action> inputcommands, Character character) {

        List<TestOutput> outputList = new List<TestOutput>();
        SetActiveCharacter(character);
        foreach (Action commmand in inputcommands) {
            commmand();
            outputList.Add(new TestOutput(ActiveCharacter.Icon, ActiveCharacter.Position));
        }

        return outputList;
    }

    // Add all commands to lists
    private void SetUpInput() {

        // Create list of commands
        // DigitalController
        InputCommandsList.Add(() => dCon.OnGamePad(Direction.Right));
        InputCommandsList.Add(() => dCon.OnGamePad(Direction.Right));
        InputCommandsList.Add(() => dCon.OnGamePad(Direction.Right));
        InputCommandsList.Add(() => dCon.OnGamePad(Direction.Up));
        InputCommandsList.Add(() => dCon.OnGamePad(Direction.Up));
        InputCommandsList.Add(() => dCon.OnGamePad(Direction.Up));
        InputCommandsList.Add(() => dCon.OnGamePad(Direction.Left));
        InputCommandsList.Add(() => dCon.OnGamePad(Direction.Left));
        InputCommandsList.Add(() => dCon.OnGamePad(Direction.Left));
        InputCommandsList.Add(() => dCon.OnGamePad(Direction.Down));
        InputCommandsList.Add(() => dCon.OnGamePad(Direction.Down));
        InputCommandsList.Add(() => dCon.OnGamePad(Direction.Down));

        //AnalogController
        InputCommandsList.Add(() => aCon.OnAnalogStick(0.5f, 0.0f));
        InputCommandsList.Add(() => aCon.OnAnalogStick(0.5f, 0.0f));
        InputCommandsList.Add(() => aCon.OnAnalogStick(0.5f, 0.0f));
        InputCommandsList.Add(() => aCon.OnAnalogStick(0.0f, 0.5f));
        InputCommandsList.Add(() => aCon.OnAnalogStick(0.0f, 0.5f));
        InputCommandsList.Add(() => aCon.OnAnalogStick(0.0f, 0.5f));
        InputCommandsList.Add(() => aCon.OnAnalogStick(-0.5f, 0.0f));
        InputCommandsList.Add(() => aCon.OnAnalogStick(-0.5f, 0.0f));
        InputCommandsList.Add(() => aCon.OnAnalogStick(-0.5f, 0.0f));
        InputCommandsList.Add(() => aCon.OnAnalogStick(0.0f, -0.5f));
        InputCommandsList.Add(() => aCon.OnAnalogStick(0.0f, -0.5f));
        InputCommandsList.Add(() => aCon.OnAnalogStick(0.0f, -0.5f));

        // Motion Controller
        // Implement Motion Controller test here ***

    }

    private void PopulateExpectedTestOutputForCharacter(Character c) {

        //For Each Character
        ExpectedTestOutputList = new List<TestOutput>();

        // Digital Controller
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(1, 0)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(2, 0)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(3, 0)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(3, 1)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(3, 2)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(3, 3)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(2, 3)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(1, 3)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(0, 3)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(0, 2)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(0, 1)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(0, 0)));

        // Analog Controller
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(1, 0)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(2, 0)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(3, 0)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(3, 1)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(3, 2)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(3, 3)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(2, 3)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(1, 3)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(0, 3)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(0, 2)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(0, 1)));
        ExpectedTestOutputList.Add(new TestOutput(c.Icon, new Coords(0, 0)));

        // Motion Controller
        // Added test output for Motion Controller
    }

    private void SetActiveCharacter(Character character) {

        ActiveCharacter = character;
        activeCharacterIcon = ActiveCharacter.Icon;
    }

    private void VerifyTestResults(List<TestOutput> testOutputList) {

        int totalIncorrect = 0;
        for (int i = 0; i < testOutputList.Count; ++i) {
            if (!testOutputList[i].Equals(ExpectedTestOutputList[i])) {
                totalIncorrect++;
            }

            System.Diagnostics.Debug.WriteLine(testOutputList[i].icon + " -> " + testOutputList[i].coords.x + ", " + testOutputList[i].coords.y + "|||" + ExpectedTestOutputList[i].coords.x + ", " + ExpectedTestOutputList[i].coords.y);
        }

        System.Diagnostics.Debug.WriteLine("Test Ran with {0} wrong answers", totalIncorrect);
    }

}