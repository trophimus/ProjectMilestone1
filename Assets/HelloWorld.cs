using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    public string message = "Hello World from Unity!";
    // My  game starts

    void Start()
    {
       // Debug.Log("Hello World");
       // Debug.Log("Welcome to Unity Dev World!");

        Debug.Log(message);
    }
    public void SayHello()
    {
        Debug.Log("Unity says:" + message);
    }
}
