using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public int highscore;
    public bool startGame = false;

	// Use this for initialization
	void Start () {
        highscore = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (ControllerInput.swordStart == true) {
            startGame = true;
        }
	}

    public bool startTheGame(){
        return startGame;
    }

    public void setGameStart(){
        startGame = true;
    }
}
