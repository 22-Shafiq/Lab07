using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager thisManager = null;  
    [SerializeField] private Text Txt_Score = null;
    [SerializeField] private Text Txt_Message = null;
    private int Score = 0;
    public GameObject uiScore;
    //public GameObject uiText;

    void Start()
    {
        thisManager = this;
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.Return))
            StartGame();
    }

    public void UpdateScore()
    {
        Score += 1;
        Txt_Score.text = "SCORE : " + Score;
    }

    private void StartGame()
    {
        Score = 0;
        Time.timeScale = 1;
        Txt_Message.text = "";
        uiScore.SetActive(true);
        Txt_Score.text = "SCORE : 0";
        //uiText.SetActive(true);

    }

    public void GameOver()
    {
        //Time.timeScale = 0;
        //Txt_Message.text = "GAMEOVER! \nPRESS ENTER TO RESTART GAME.";
        //Txt_Message.color = Color.red;
        SceneManager.LoadScene("LoseScene");

    }
    
}
