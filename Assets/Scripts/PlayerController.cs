using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private static int playersInstantiated;
    private int healthPoint;
    private int playerNumber;

    private List<string> moves;

    // Start is called before the first frame update
    public void Start () {
        healthPoint = 100;
        moves = new List<string>();
        playerNumber = playersInstantiated++;
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
