using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    private AudioSource _audio;
    public int Code
    {
        get 
        {
            return code; 
        }
        set { } 
    }
    private int code = 2;
    public static Cat Instance;
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
        MainManager.Instance.ChangeCamera(gameObject.transform.position, Name, "Meow", _audio, Code);
    }
    // Start is called before the first frame update
    void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
        _audio.enabled = false;
        Name = "Cat";
        Size = 1;
    }

    
}
