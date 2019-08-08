using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SkipStory : MonoBehaviour
{
    public int SkipTo;
    public void Skipstory()
    {
        SceneManager.LoadScene(SkipTo);
    }
}
