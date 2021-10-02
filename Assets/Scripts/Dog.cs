using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private AudioSource _audio;
    
    public static Dog Instance;
    private int code = 0;
    public int Code
    {
        get
        {
            return code;
        }
        set { }
    }
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    public override void Sound()
    {
        _audio.Play(0);
    }
    public void OnMouseDown()
    {
        _audio.enabled = true;
        MainManager.Instance.ChangeCamera(gameObject.transform.position,  Name, "Bark", _audio, Code);
    }

    // Start is called before the first frame update
    void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
        _audio.enabled = false;
        Size = 1;
        Name = "Dog";
    }


}