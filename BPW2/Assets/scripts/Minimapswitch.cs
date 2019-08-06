using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimapswitch : MonoBehaviour
{
    public KeyCode Minimapkey;
    public GameObject Minimap;
    public int Mapstate;
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Minimapkey))
        {
            if (Mapstate == 0)
            {
                Mapstate = 1;
                Minimap.SetActive(true);
            }
            else
            {
                Mapstate = 0;
                Minimap.SetActive(false);
            }
        }
    }
}
