using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController1 : MonoBehaviour
{
    public KeyCode upKey, downKey, leftKey, rightKey, interactionKey;
    public float moveSpeed = 6f;
    private Rigidbody2D rb;
    public GameObject visualPlayer;
    private bool standingOnPickup;
    private Pickup pickUp;
    public Text ScoreVlees;
    public Text ScoreVis;
    public Text ScoreKruidjes;
    public Text ScorePeper;
    public Text ScoreGroente;

    private int AantVlees;
    private int AantVis;
    private int AantKruidjes;
    private int AantPeper;
    private int AantGroente;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        AantVlees = 0;
        AantVis = 0;
        AantKruidjes = 0;
        AantPeper = 0;
        AantGroente = 0;

        ScoreVlees.text = AantVlees.ToString();
        ScoreVis.text = AantVis.ToString();
        ScoreKruidjes.text = AantKruidjes.ToString();
        ScorePeper.text = AantPeper.ToString();
        ScoreGroente.text = AantGroente.ToString();
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

            pickUp.PickedUp();

            if (foodType == Food_Type.Vlees)
            {
                AantVlees += 1;
                ScoreVlees.text = AantVlees.ToString();
            }

            else if (foodType == Food_Type.Vis)
            {
                AantVis += 1;
                ScoreVis.text = AantVis.ToString();
            }

            else if (foodType == Food_Type.Kruidjes)
            {
                AantKruidjes += 1;
                ScoreKruidjes.text = AantKruidjes.ToString();
            }

            else if (foodType == Food_Type.Peper)
            {
                AantPeper += 1;
                ScorePeper.text = AantPeper.ToString();
            }
            
            else if (foodType == Food_Type.Groente)
            {
                AantGroente += 1;
                ScoreGroente.text = AantGroente.ToString();
            }
            
           
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            standingOnPickup = true;
            pickUp = other.gameObject.GetComponent<Pickup>();
            Debug.Log("we collided wwooooow" + other.gameObject.name);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        standingOnPickup = false;
    }
}
