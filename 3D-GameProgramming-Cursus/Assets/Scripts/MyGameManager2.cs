using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager2 : MonoBehaviour
{
    public enum GameStates { Playing, GameOver }

    public GameObject Player;
    public GameObject MainCanvas;
    public GameObject GameOverCanvas;
    public GameStates GameState = GameStates.Playing;

    private Health healthOfPlayer;

    // Start is called before the first frame update
    void Start()
    {
        if (Player is null)
            Player = GameObject.FindWithTag("Player");
        healthOfPlayer = Player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (GameState)
        {
            case GameStates.Playing:
                if (!healthOfPlayer.isAlive)
                {
                    GameState = GameStates.GameOver;
                    MainCanvas.SetActive(false);
                    GameOverCanvas.SetActive(true);
                }
                break;
        }

    }
}
