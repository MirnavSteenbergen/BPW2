using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public KeyCode upKey, downKey, leftKey, rightKey, interactionKey;
    public float moveSpeed = 6f;
    private Rigidbody2D rb;
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
            transform.position += Vector3.up * Time.deltaTime * moveSpeed;
        }
        else if (Input.GetKey(leftKey))
        {
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        }
        else if (Input.GetKey(downKey))
        {
            transform.position += Vector3.down * Time.deltaTime * moveSpeed;
        }
        else if (Input.GetKey(rightKey))
        {
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKeyDown(interactionKey))
        {
            //interact with object
        }
    }
}
