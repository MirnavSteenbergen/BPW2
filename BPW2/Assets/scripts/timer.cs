using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public Text uiTime;
    public float StartTime;
    public float CurrentTime;
    public float speed = 1;

    public int Gelijkspel;
    public int WinPlayer1;
    public int WinPlayer2;

    private void Start()
    {
        CurrentTime = StartTime;
        uiTime = GetComponent<Text>();
    }

    private void Update()
    {
        if (CurrentTime > 0.01)
        {
            CurrentTime -= Time.deltaTime * speed;
            string minutes = Mathf.Floor((CurrentTime % 3600) / 60).ToString("00");
            string seconds = Mathf.Floor(CurrentTime % 60).ToString("00");
            uiTime.text = minutes + ":" + seconds;
        }
        else uiTime.text = "00:00";

        if (CurrentTime <= 0.01)
        {
            endgame();
        }
    }

    void endgame()
    {
        Debug.Log("endgame triggered");
        if (GameObject.FindGameObjectWithTag("Player1").GetComponent<PlayerController1>().Score == GameObject.FindGameObjectWithTag("Player2").GetComponent<PlayerController1>().Score)
        {
            SceneManager.LoadScene(Gelijkspel);
        }
        else if (GameObject.FindGameObjectWithTag("Player1").GetComponent<PlayerController1>().Score > GameObject.FindGameObjectWithTag("Player2").GetComponent<PlayerController1>().Score)
        {
            SceneManager.LoadScene(WinPlayer1);
        }
        else if (GameObject.FindGameObjectWithTag("Player1").GetComponent<PlayerController1>().Score < GameObject.FindGameObjectWithTag("Player2").GetComponent<PlayerController1>().Score)
        {
            SceneManager.LoadScene(WinPlayer2);
        }

    }
}
