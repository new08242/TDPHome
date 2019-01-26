using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public void Hello()
    {
        Debug.Log("hello world");
        Debug.Log("increase hp");

        HealthDisplay.instance.health++;
    }
}
