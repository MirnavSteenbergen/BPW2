using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float RespawnTime = 2f;
    public Food_Type foodType;
    // Update is called once per frame
    void Update()
    {
        //if (player picks up pickup){
        //    gameObject.SetActive = false;
            

        //}

        
    }

    //IEnumerator PickUp()
    //{
    //    yield return new WaitForSeconds(RespawnTime);
    //    gameObject.SetActive = true;
    //    return null;
    //}
                
}
public enum Food_Type
{
    Vlees,
    Vis,
    Groente,
    Peper,
    Kruidjes
}
