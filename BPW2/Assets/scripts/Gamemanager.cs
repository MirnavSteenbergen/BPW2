using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public float currentTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime <= 0)
        {
            endgame();
        }
    }

    void endgame()
    {
        //enable endui met eindscores spelers
        //next scene/level
    }
}
