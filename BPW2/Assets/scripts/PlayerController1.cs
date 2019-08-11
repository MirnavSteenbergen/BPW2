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
    private bool deliveryattempt;
    private Pickup pickUp;
    public int PlayerNumber;
    public Text scoreTotal;
    public int Score;

    //tweede inventory systeem
    public int ItemInInventorySlot1;
    public int ItemInInventorySlot2;
    public int ItemInInventorySlot3;

    private bool AttemptToTrash;
    private bool InventorySlotIsFilled1;
    private bool InventorySlotIsFilled2;
    private bool InventorySlotIsFilled3;

    public GameObject InventorySlot11;
    public GameObject InventorySlot12;
    public GameObject InventorySlot13;
    public GameObject InventorySlot14;
    public GameObject InventorySlot15;

    public GameObject InventorySlot21;
    public GameObject InventorySlot22;
    public GameObject InventorySlot23;
    public GameObject InventorySlot24;
    public GameObject InventorySlot25;

    public GameObject InventorySlot31;
    public GameObject InventorySlot32;
    public GameObject InventorySlot33;
    public GameObject InventorySlot34;
    public GameObject InventorySlot35;

    //Pick-up sound
    public AudioClip PickUp;
    public AudioSource PlayerAudio;
    public AudioSource CorrectObjectGiven;

    //walk animation
    public Animator walkAnim;

    // Start is called before the first frame update
    void Start()
    {
        PlayerAudio.clip = PickUp;
        rb = GetComponent<Rigidbody2D>();
        
        Score = 0;
        scoreTotal.text = "Score: " + Score.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        //walk animation
        if(Input.GetKey(rightKey) || Input.GetKey(leftKey) || Input.GetKey(downKey) || Input.GetKey(upKey))
        {
            walkAnim.SetBool("Moving", true);
        }
        else
        {
            walkAnim.SetBool("Moving", false);
        }

        //player movement
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
                
                if (InventorySlotIsFilled1 == false)
                {
                    InventorySlotIsFilled1 = true;
                    ItemInInventorySlot1 = 1;
                    InventorySlot11.gameObject.SetActive(true);
                    PlayerAudio.Play();
                }
                else if (InventorySlotIsFilled2 == false)
                {
                    InventorySlotIsFilled2 = true;
                    ItemInInventorySlot2 = 1;
                    InventorySlot21.gameObject.SetActive(true);
                    PlayerAudio.Play();
                }
                else if (InventorySlotIsFilled3 == false)
                {
                    InventorySlotIsFilled3 = true;
                    ItemInInventorySlot3 = 1;
                    InventorySlot31.gameObject.SetActive(true);
                    PlayerAudio.Play();
                }
            }

            else if (foodType == Food_Type.Vis)
            {
                
                if (InventorySlotIsFilled1 == false)
                {
                    InventorySlotIsFilled1 = true;
                    ItemInInventorySlot1 = 4;
                    InventorySlot14.gameObject.SetActive(true);
                    PlayerAudio.Play();

                }
                else if (InventorySlotIsFilled2 == false)
                {
                    InventorySlotIsFilled2 = true;
                    ItemInInventorySlot2 = 4;
                    InventorySlot24.gameObject.SetActive(true);
                    PlayerAudio.Play();
                }
                else if (InventorySlotIsFilled3 == false)
                {
                    InventorySlotIsFilled3 = true;
                    ItemInInventorySlot3 = 4;
                    InventorySlot34.gameObject.SetActive(true);
                    PlayerAudio.Play();
                }
            }

            else if (foodType == Food_Type.Kruidjes)
            {
                
                if (InventorySlotIsFilled1 == false)
                {
                    InventorySlotIsFilled1 = true;
                    ItemInInventorySlot1 = 2;
                    InventorySlot12.gameObject.SetActive(true);
                    PlayerAudio.Play();
                }
                else if (InventorySlotIsFilled2 == false)
                {
                    InventorySlotIsFilled2 = true;
                    ItemInInventorySlot2 = 2;
                    InventorySlot22.gameObject.SetActive(true);
                    PlayerAudio.Play();
                }
                else if (InventorySlotIsFilled3 == false)
                {
                    InventorySlotIsFilled3 = true;
                    ItemInInventorySlot3 = 2;
                    InventorySlot32.gameObject.SetActive(true);
                    PlayerAudio.Play();
                }
            }

            else if (foodType == Food_Type.Peper)
            {
                
                if (InventorySlotIsFilled1 == false)
                {
                    InventorySlotIsFilled1 = true;
                    ItemInInventorySlot1 = 3;
                    InventorySlot13.gameObject.SetActive(true);
                    PlayerAudio.Play();
                }
                else if (InventorySlotIsFilled2 == false)
                {
                    InventorySlotIsFilled2 = true;
                    ItemInInventorySlot2 = 3;
                    InventorySlot23.gameObject.SetActive(true);
                    PlayerAudio.Play();
                }
                else if (InventorySlotIsFilled3 == false)
                {
                    InventorySlotIsFilled3 = true;
                    ItemInInventorySlot3 = 3;
                    InventorySlot33.gameObject.SetActive(true);
                    PlayerAudio.Play();
                }
            }

            else if (foodType == Food_Type.Groente)
            {
               
                if (InventorySlotIsFilled1 == false)
                {
                    InventorySlotIsFilled1 = true;
                    ItemInInventorySlot1 = 5;
                    InventorySlot15.gameObject.SetActive(true);
                    PlayerAudio.Play();
                }
                else if (InventorySlotIsFilled2 == false)
                {
                    InventorySlotIsFilled2 = true;
                    ItemInInventorySlot2 = 5;
                    InventorySlot25.gameObject.SetActive(true);
                    PlayerAudio.Play();
                }
                else if (InventorySlotIsFilled3 == false)
                {
                    InventorySlotIsFilled3 = true;
                    ItemInInventorySlot3 = 5;
                    InventorySlot35.gameObject.SetActive(true);
                    PlayerAudio.Play();
                }
            }


        }

        if (Input.GetKeyDown(interactionKey) && AttemptToTrash == true)
        {
            ResetInventorySlot1();
            ResetInventorySlot2();
            ResetInventorySlot3();
        }

        if (Input.GetKeyDown(interactionKey) && deliveryattempt == true && PlayerNumber == 1)
        {
            // check if desired food is being delivered
            if (ItemInInventorySlot1 == GameObject.FindGameObjectWithTag("Delivery").GetComponent<IngrediëntQuest>().Questnumber)
            {
                ResetInventorySlot1();
                //add score
                Score += 1;
                scoreTotal.text = "Score: " + Score.ToString();
                CorrectObjectGiven.Play();
                GameObject.FindGameObjectWithTag("Delivery").GetComponent<IngrediëntQuest>().NewQuest();
            }
            else if (ItemInInventorySlot2 == GameObject.FindGameObjectWithTag("Delivery").GetComponent<IngrediëntQuest>().Questnumber)
            {
                ResetInventorySlot2();
                //add score
                Score += 1;
                scoreTotal.text = "Score: " + Score.ToString();
                CorrectObjectGiven.Play();
                GameObject.FindGameObjectWithTag("Delivery").GetComponent<IngrediëntQuest>().NewQuest();
            }
            else if (ItemInInventorySlot3 == GameObject.FindGameObjectWithTag("Delivery").GetComponent<IngrediëntQuest>().Questnumber)
            {
                ResetInventorySlot3();
                //add score
                Score += 1;
                scoreTotal.text = "Score: " + Score.ToString();
                CorrectObjectGiven.Play();
                GameObject.FindGameObjectWithTag("Delivery").GetComponent<IngrediëntQuest>().NewQuest(); 
            }
        }

        if (Input.GetKeyDown(interactionKey) && deliveryattempt == true && PlayerNumber == 2)
        {
            // check if desired food is being delivered
            if (ItemInInventorySlot1 == GameObject.FindGameObjectWithTag("Delivery1").GetComponent<IngrediëntQuest>().Questnumber)
            {
                ResetInventorySlot1();
                //add score
                Score += 1;
                scoreTotal.text = "Score: " + Score.ToString();
                CorrectObjectGiven.Play();
                GameObject.FindGameObjectWithTag("Delivery1").GetComponent<IngrediëntQuest>().NewQuest();
            }
            else if (ItemInInventorySlot2 == GameObject.FindGameObjectWithTag("Delivery1").GetComponent<IngrediëntQuest>().Questnumber)
            {
                ResetInventorySlot2();
                //add score
                Score += 1;
                scoreTotal.text = "Score: " + Score.ToString();
                CorrectObjectGiven.Play();
                GameObject.FindGameObjectWithTag("Delivery1").GetComponent<IngrediëntQuest>().NewQuest();
            }
            else if (ItemInInventorySlot3 == GameObject.FindGameObjectWithTag("Delivery1").GetComponent<IngrediëntQuest>().Questnumber)
            {
                ResetInventorySlot3();
                //add score
                Score += 1;
                scoreTotal.text = "Score: " + Score.ToString();
                CorrectObjectGiven.Play();
                GameObject.FindGameObjectWithTag("Delivery1").GetComponent<IngrediëntQuest>().NewQuest();
            }
        }

            
        
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Delivery" && PlayerNumber == 1)
        {
            deliveryattempt = true;
            Debug.Log("delivery attempted by player 1");
        }

        if (other.gameObject.tag == "Delivery1" && PlayerNumber == 2)
        {
            deliveryattempt = true;
            Debug.Log("delivery attempted by player 2");
        }

        if (other.gameObject.tag == "PickUp")
        {
            standingOnPickup = true;
            pickUp = other.gameObject.GetComponent<Pickup>();
        }

        if (other.gameObject.tag == "Afvalbak")
        {
            AttemptToTrash = true;
            Debug.Log("trash attempted");
        }
    }

        private void OnCollisionExit2D(Collision2D collision)
        {
            standingOnPickup = false;
            deliveryattempt = false;
            AttemptToTrash = false;
        }

        private void ResetInventorySlot1()
        {
            ItemInInventorySlot1 = 0;
            InventorySlotIsFilled1 = false;
            InventorySlot11.gameObject.SetActive(false);
            InventorySlot12.gameObject.SetActive(false);
            InventorySlot13.gameObject.SetActive(false);
            InventorySlot14.gameObject.SetActive(false);
            InventorySlot15.gameObject.SetActive(false);
        }
        private void ResetInventorySlot2()
        {
            ItemInInventorySlot2 = 0;
            InventorySlotIsFilled2 = false;
            InventorySlot21.gameObject.SetActive(false);
            InventorySlot22.gameObject.SetActive(false);
            InventorySlot23.gameObject.SetActive(false);
            InventorySlot24.gameObject.SetActive(false);
            InventorySlot25.gameObject.SetActive(false);
        }
        private void ResetInventorySlot3()
        {
            ItemInInventorySlot3 = 0;
            InventorySlotIsFilled3 = false;
            InventorySlot31.gameObject.SetActive(false);
            InventorySlot32.gameObject.SetActive(false);
            InventorySlot33.gameObject.SetActive(false);
            InventorySlot34.gameObject.SetActive(false);
            InventorySlot35.gameObject.SetActive(false);
        }
    

}
