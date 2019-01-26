using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    private int healthPoint;
    private string[] moves;
    private int playerNumber;


    // Start is called before the first frame update
    void Start()
    {
        this.healthPoint = 100;
        this.moves = new string[5];
    }

    public void CalculateMoves()
    {
        for (int i = 0; i < moves.Length; i++) {
            calculateMove(moves[i]);
        }
    }

    private void calculateMove(string move)
    {

    }
}
