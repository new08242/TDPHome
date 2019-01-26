using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(SetEnemyActive());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SetEnemyActive() {
      for(int i = 0; i < enemies.Length; i++) {
        yield return new WaitForSeconds(0.5f);
        enemies[i].SetActive(true);
      }
    }
}
