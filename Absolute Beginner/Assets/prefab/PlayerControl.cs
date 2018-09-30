using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    bool grounded = false;
    bool gameOver = false;
    bool win = false;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        /*
        var x = 3 * Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = 3 * Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        */
        float move = 0.15f;
        float turn = 4.0f;
        if(Input.GetKey("w"))
        {
            transform.Translate(0, 0, move);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, -move);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-move, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(move, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -turn, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, turn, 0);
        }

        if (gameOver == true)
        {
            //scene change
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "GameGround")
        {
            grounded = true;
        }
        if (collision.gameObject.name == "monkey")
        {
            //scene change
            gameOver = true;
        }
        if(collision.gameObject.name =="trophie_gold_A")
        {
            win = true;
            //change scenes 
        }
    }
}
