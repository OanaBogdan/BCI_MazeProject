using UnityEngine;
using Unicorn;

public class BCIController : MonoBehaviour
{
    private UnicornDevice device;
    private MazeNavigator mazeNavigator;

    void Start()
    {
        device = new UnicornDevice();
        mazeNavigator = GetComponent<MazeNavigator>();
    }

    void Update()
    {
        string command = GetBCICommand();
        switch (command)
        {
            case "forward":
                mazeNavigator.MoveForward();
                break;
            case "left":
                mazeNavigator.TurnLeft();
                break;
            case "right":
                mazeNavigator.TurnRight();
                break;
        }
    }

    string GetBCICommand()
    {
        float[] data = device.GetData();
        if (data[0] > 0.5f)
            return "forward";
        else if (data[1] > 0.5f)
            return "left";
        else if (data[2] > 0.5f)
            return "right";
        else
            return "";
    }
}