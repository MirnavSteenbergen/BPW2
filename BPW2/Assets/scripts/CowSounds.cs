using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowSounds : MonoBehaviour
{
    public AudioSource Cow;
    private int countPlayers = 0;
    public float TimeInbetween;

    void Start()
    {
        StartCoroutine("CowMoo");
    }

    IEnumerator CowMoo()
    {
        for (; ; )
        {
            if (0 < countPlayers)
            {
                if (!Cow.isPlaying)
                {
                    Cow.Play();
                    yield return new WaitForSeconds(TimeInbetween);
                }
            }
            yield return null;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ("Player1" == other.gameObject.tag || "Player2" == other.gameObject.tag)
        {
            countPlayers++;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if ("Player1" == other.gameObject.tag || "Player2" == other.gameObject.tag)
        {
            countPlayers--;
        }
    }
}
