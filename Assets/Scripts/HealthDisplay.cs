using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public static HealthDisplay instance;
    public int health = 5;
    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "HEALTH : " + health;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            health--;
            Debug.Log("decrease hp");
        }
    }
}
