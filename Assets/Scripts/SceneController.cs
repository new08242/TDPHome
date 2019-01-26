using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    private List<PlayerController> playerControllers;
    private int turn;
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
        playerControllers[turn].CalculateMoves();
        turn++;
        turn = turn % GameState.NumPlayers;
        Debug.Log("turn:" + turn);
    }
}
