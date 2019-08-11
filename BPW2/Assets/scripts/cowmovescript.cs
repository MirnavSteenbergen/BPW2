using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cowmovescript : MonoBehaviour
{
    public GameObject VisualCow;

    [SerializeField]
    private Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 2f;

    private int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveIt();
    }

    private void MoveIt()
    {
        transform.position = Vector2.MoveTowards(transform.position,
            waypoints[waypointIndex].transform.position,
            moveSpeed * Time.deltaTime);

        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex += 1;
        }

        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }

        if (waypointIndex == 0)
        {
            VisualCow.transform.eulerAngles = new Vector3(0, 0, -90);
        }
        else if (waypointIndex == 1)
        {
            VisualCow.transform.eulerAngles = new Vector3(0, 0, 180);
        }
        else if (waypointIndex == 2)
        {
            VisualCow.transform.eulerAngles = new Vector3(0, 0, 90);
        }
        else if (waypointIndex == 3)
        {
            VisualCow.transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
