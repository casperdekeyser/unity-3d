using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log($"Platform collided, going to next level (current score = {CoinPickup.Score})");
            SceneManager.LoadScene("RocketGameLevel2");
        }
    }
}
