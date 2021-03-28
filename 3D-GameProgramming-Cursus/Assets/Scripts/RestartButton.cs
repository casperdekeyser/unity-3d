using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public string mLevelToLoad;

    public void LoadLevel()
    {
        // Load the new level
        SceneManager.LoadScene(mLevelToLoad);

        // Reset score
        CoinPickup.Score = 0;
    }
}
