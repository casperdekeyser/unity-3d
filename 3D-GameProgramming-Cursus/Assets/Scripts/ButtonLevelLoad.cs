using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevelLoad : MonoBehaviour
{

    public string LevelToLoad;

    public void LoadLevel()
    {
        // Load the new level
        SceneManager.LoadScene(LevelToLoad);
    }
}
