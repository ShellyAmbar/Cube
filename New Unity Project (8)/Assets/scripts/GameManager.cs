using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public float Delay = 1f;
    public GameObject GameOverUI;
    bool GetIn = true;
    public void EndOfGame() {
        if (GetIn)
        {
            GetIn = false;
            Debug.Log("GameOver");
            Invoke("ReStart", Delay);
        }
    }
    public void ReStart() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel() {
        GameOverUI.SetActive(true);
    }
}
