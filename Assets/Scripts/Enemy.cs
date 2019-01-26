﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int health;
    
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        fadeIn();
    }

    void fadeIn()
    {
        Color tmp = gameObject.GetComponent<SpriteRenderer>().color;
        tmp.a = 0f;
        gameObject.GetComponent<SpriteRenderer>().color = tmp;

        StartCoroutine(FadeIn(tmp));
    }

    private IEnumerator FadeIn(Color tmp) {
        for (float i = tmp.a; i < 1; i+=0.1f) {
            tmp.a = i;
            gameObject.GetComponent<SpriteRenderer>().color = tmp;
            yield return new WaitForSeconds(0.03f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
