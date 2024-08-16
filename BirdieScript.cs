using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdieScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float strength;
    public LogicScript logic;
    public bool birdAlive = true;
    private AudioSource aud;
    public AudioClip hiiClip;
    public AudioClip byeeClip;
    


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logg").GetComponent<LogicScript>();
        
        aud = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdAlive) { 
        myRigidBody.velocity = Vector2.up * strength;
        aud.PlayOneShot(hiiClip);
        
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdAlive = false;
        
        aud.PlayOneShot(byeeClip);
    }


}
