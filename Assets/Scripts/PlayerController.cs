using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private static int noOfPlayers;
    private int healthPoint;
    private int playerNumber;
    private List<string> moves;

    // Start is called before the first frame update
    public PlayerController() {
        healthPoint = 100;
        moves = new List<string>();
        playerNumber = noOfPlayers++;
    }

    public void CalculateMoves()
    {
        for (int i = 0; i < moves.Count; i++) {
            calculateMove(moves[i]);
        }
    }

    private void calculateMove(string move)
    {
        Debug.Log("Inside calculate move");
    }
}
