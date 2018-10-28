using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public static ScoreController scoreController = null;

    public Text scoreText;

    public int player1Score;
    public int player2Score;

    void Awake()
    {
        if (scoreController == null) scoreController = this;
        else Destroy(this.gameObject);
    }

	void Start () {
        player1Score = 0;
        player2Score = 0;

        scoreText.text = "0 : 0";
	}

    public void GivePointtoPlayer(int playerID)
    {
        switch (playerID)
        {
            case 1:
                player1Score++;
                break;
            case 2:
                player2Score++;
                break;
            default:
                break;
        }
        scoreText.text = player1Score.ToString() + " : " + player2Score.ToString();
    }
}
