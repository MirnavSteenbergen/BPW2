using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour
{
    public KeyCode NextTextKey;
    public int TextNr;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject Text7;
    public GameObject Text8;

    // Start is called before the first frame update
    void Start()
    {
        TextNr = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(NextTextKey))
        {
            TextNr += 1;
        }

        if (TextNr == 1)
        {
            Text1.gameObject.SetActive(true);
        }

        else if (TextNr == 2)
        {
            Text1.gameObject.SetActive(false);
            Text2.gameObject.SetActive(true);
        }

        else if (TextNr == 3)
        {
            Text2.gameObject.SetActive(false);
            Text3.gameObject.SetActive(true);
        }

        else if (TextNr == 4)
        {
            Text3.gameObject.SetActive(false);
            Text4.gameObject.SetActive(true);
        }

        else if (TextNr == 5)
        {
            Text4.gameObject.SetActive(false);
            Text5.gameObject.SetActive(true);
        }

        else if (TextNr == 6)
        {
            Text5.gameObject.SetActive(false);
            Text6.gameObject.SetActive(true);
        }

        else if (TextNr == 7)
        {
            Text6.gameObject.SetActive(false);
            Text7.gameObject.SetActive(true);
        }

        else if (TextNr == 8)
        {
            Text7.gameObject.SetActive(false);
            Text8.gameObject.SetActive(true);
        }

        else if (TextNr == 9)
        {
            SceneManager.LoadScene(1);
        }
    }
}
