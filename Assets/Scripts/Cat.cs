using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
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
        Name = "Cat";
        Size = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
