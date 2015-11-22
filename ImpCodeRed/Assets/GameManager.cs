using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    public int score;
    public int winScore;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;
        if (score > winScore)
        {
            Debug.Log("Win!");
           Application.LoadLevel("YouWin");
        }

	}

    public void AddScore()
    {
        score++;
    }
}
