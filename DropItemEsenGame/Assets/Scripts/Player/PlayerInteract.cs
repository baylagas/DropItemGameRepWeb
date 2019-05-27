using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public int score;
    public int addToScore;
    public GameObject gameManagerObj;
    public GameManagerController gameManagerScript;

    private void Start()
    {
        score = 0;
        gameManagerObj = GameObject.Find("GameManager");
        gameManagerScript = gameManagerObj.GetComponent<GameManagerController>();
        gameManagerScript.ModifyGameScore(score);
        gameManagerScript.SetScoreText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("GoodItem"))
        {
            Debug.Log("player has a good item");
            Destroy(collision.gameObject);
            ModifyScore(addToScore);
            gameManagerScript.ModifyGameScore(score);
            gameManagerScript.SetScoreText();
        }
    }

    public void ModifyScore(int value)
    {
        score += value;
    }
}
