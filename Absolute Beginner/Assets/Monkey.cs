using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monkey : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    private const float Z = 0.125f;
    public Transform player;
    bool ded = false;
    void Update()
    {
        //Look at the player
        if (Input.GetKey("p"))
        {
            SceneManager.LoadScene("game");
        }
        if (!ded)
        {
            transform.LookAt(player);
            transform.Translate(0.0f, 0.0f, Z);
        }
        else if (ded)
        {
            SceneManager.LoadScene("Game Over");
        }
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "player")
        {
            Destroy(collision.gameObject);
            ded = true;
            
        }
    }
}
