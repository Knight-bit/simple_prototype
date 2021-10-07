using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Animal
{
    private AudioSource _audio;
    
    public static Cow Instance;
    public int Code
    {
        get
        {
            return code;
        }
        set { }
    }
    private int code = 3;
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
        MainManager.Instance.ChangeCamera(gameObject.transform.position, Name, "Mugir", _audio, Code);
    }
    // Start is called before the first frame update
    void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
        _audio.enabled = false;
        Size = 1;
        Name = "Cow";
    }
    

}
