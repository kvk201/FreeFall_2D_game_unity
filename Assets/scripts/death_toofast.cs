using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death_toofast : MonoBehaviour
{
    public GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var rb = player.GetComponent<Rigidbody2D>();
        var v = Mathf.Abs(rb.velocity.y);

        Debug.Log(v);
        if (v>10)
        {
            Debug.Log("too fast" + v);
        }
    }
}
