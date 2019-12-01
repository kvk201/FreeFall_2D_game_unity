using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public Transform pl;
    public GameObject playerObject;
    public Vector2 playerPos;
    private Vector2 starting_point;
    
    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.Find("player");
        starting_point = playerObject.transform.position;
        //Debug.Log("starting point: " + starting_point);

    }

    // Update is called once per frame
    void Update()
    {
        playerPos = playerObject.transform.position;
        //Debug.Log("current position: " + playerPos);
    }

    public void OnTriggerEnter2D()
    {
        Debug.Log("dead");
        

        

    }

    public void OnCollisionEnter2D()
    {
        Debug.Log("dead2");
        //add delay here


        playerObject.transform.position = starting_point;
    }
}
