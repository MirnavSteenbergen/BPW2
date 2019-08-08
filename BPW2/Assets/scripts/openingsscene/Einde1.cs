using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Einde1 : MonoBehaviour
{
    public KeyCode NextTextKey;
    public int TextNr;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;

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
            SceneManager.LoadScene(0);
        }
    }


}
