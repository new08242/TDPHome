using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {

    private int numPlayers;
    private List<PlayerController> playerControllers;
    private int turn;

    public GameObject PlayerSprite;

    public GameState() {
        numPlayers = 1;
        playerControllers = new List<PlayerController>();
    }

    public GameState(int numPlayers) {
        this.numPlayers = numPlayers;
        playerControllers = new List<PlayerController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numPlayers; i++) {
            GameObject spriteObject = Instantiate(PlayerSprite, new Vector3(0, 0, 0), Quaternion.identity);
            playerControllers.Add(spriteObject.GetComponent<PlayerController>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerControllers[turn].CalculateMoves();
        turn++;
        turn = turn % numPlayers;
        Debug.Log("turn:" + turn);
    }
}
