using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private AudioSource audio;
    public override void Sound()
    {
        audio.Play(0);
    }

    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        Size = 1;
        Name = "Dog";
    }

    // Update is called once per frame
    void Update()
    {
          
    }
}
