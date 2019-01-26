using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    private List<PlayerController> playerControllers;
    public GameObject PlayerSprite;

    // Start is called before the first frame update    // Start is called before the first frame update
    void Start()
    {

        playerControllers = new List<PlayerController>();

        for (int i = 0; i < GameState.NumPlayers; i++) {
            GameObject spriteObject = Instantiate(PlayerSprite, new Vector3(0, 0, 0), Quaternion.identity);
            playerControllers.Add(spriteObject.GetComponent<PlayerController>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerControllers[GameState.Turn].CalculateMoves();
        GameState.Turn++;
        GameState.Turn = GameState.Turn % GameState.NumPlayers;
        Debug.Log("turn:" + GameState.Turn);
    }
}
