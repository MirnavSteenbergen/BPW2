using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngrediëntQuest : MonoBehaviour
{
    public int Questnumber;
    public GameObject vlees;
    public GameObject kruidje;
    public GameObject peper;
    public GameObject vis;
    public GameObject groente;

    // Start is called before the first frame update
    void Start()
    {
        vlees.gameObject.SetActive(false);
        kruidje.gameObject.SetActive(false);
        peper.gameObject.SetActive(false);
        vis.gameObject.SetActive(false);
        groente.gameObject.SetActive(false);

        Questnumber = Random.Range(1, 6);
    }

    // Update is called once per frame
    void Update()
    {
        if (Questnumber == 1)
        {
            vlees.gameObject.SetActive(true);
        }

        else if (Questnumber == 2)
        {
            kruidje.gameObject.SetActive(true);
        }

        else if (Questnumber == 3)
        {
            peper.gameObject.SetActive(true);
        }

        else if (Questnumber == 4)
        {
            vis.gameObject.SetActive(true);
        }

        else if (Questnumber == 5)
        {
            groente.gameObject.SetActive(true);
        }

    }

    public void NewQuest()
    {
        vlees.gameObject.SetActive(false);
        kruidje.gameObject.SetActive(false);
        peper.gameObject.SetActive(false);
        vis.gameObject.SetActive(false);
        groente.gameObject.SetActive(false);

        Questnumber = Random.Range(1, 6);
    }
}
