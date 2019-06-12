using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public KeyCode upKey, downKey, leftKey, rightKey, interactionKey;
    public float moveSpeed = 6f;
    private Rigidbody2D rb;
    public GameObject visualPlayer;
    private bool standingOnPickup;
    private Pickup pickUp;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            rb.MovePosition(transform.position + transform.up * Time.deltaTime * moveSpeed);
            visualPlayer.transform.eulerAngles = new Vector3(0, 0, 0);
            
        }
        else if (Input.GetKey(leftKey))
        {
            rb.MovePosition(transform.position + -transform.right * Time.deltaTime * moveSpeed);
            visualPlayer.transform.eulerAngles = new Vector3(0, 0, 90);
        }
        else if (Input.GetKey(downKey))
        {
            rb.MovePosition(transform.position + -transform.up * Time.deltaTime * moveSpeed);
            visualPlayer.transform.eulerAngles = new Vector3(0, 0, 180);
        }
        else if (Input.GetKey(rightKey))
        {
            rb.MovePosition(transform.position + transform.right * Time.deltaTime * moveSpeed);
            visualPlayer.transform.eulerAngles = new Vector3(0, 0, -90);
        }

        if (Input.GetKeyDown(interactionKey) && standingOnPickup == true)
        {
            Food_Type foodType = pickUp.foodType;
            //tell ui to add 1
            //remove foodobject
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            standingOnPickup = true;
            pickUp = other.gameObject.GetComponent<Pickup>();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        standingOnPickup = false;
    }
}
