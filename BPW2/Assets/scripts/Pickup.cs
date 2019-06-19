using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float RespawnTime = 2f;
    public Food_Type foodType;
    private SpriteRenderer TheSprite;
    private PolygonCollider2D TheCollider;

    private void Start()
    {
        TheSprite = gameObject.GetComponent <SpriteRenderer>();
        TheCollider = gameObject.GetComponent<PolygonCollider2D>();
    }
       

    public void PickedUp()
    {
        TheSprite.enabled = false;
        TheCollider.enabled = false;
        StartCoroutine ("RespawnFood");
    }

    IEnumerator RespawnFood()
    {
        yield return new WaitForSeconds(RespawnTime);
        TheSprite.enabled = true;
        TheCollider.enabled = true;
        yield return null;
    }

}
public enum Food_Type
{
    Vlees,
    Vis,
    Groente,
    Peper,
    Kruidjes
}
