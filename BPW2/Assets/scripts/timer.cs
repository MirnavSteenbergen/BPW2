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

        if (CurrentTime <= 0)
        {
            endgame();
        }
    }

    void endgame()
    {
        Debug.Log("endgame triggered");

        //enable endui met eindscores spelers
        //next scene/level
    }
}
