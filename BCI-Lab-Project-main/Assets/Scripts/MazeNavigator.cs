using UnityEngine;

public class MazeNavigator : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 200f;

    public void MoveForward()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    public void TurnLeft()
    {
        transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
    }

    public void TurnRight()
    {
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}