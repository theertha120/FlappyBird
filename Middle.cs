
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle : MonoBehaviour
    
{
    public LogicScript logic;
    private AudioSource aud;
    public AudioClip winClip;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logg").GetComponent<LogicScript>();
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        logic.addScore(1);
        aud.PlayOneShot(winClip);

    }
            
}
