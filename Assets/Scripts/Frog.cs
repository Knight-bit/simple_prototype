using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Frog : Animal
{
    private AudioSource _audio;
    
    public static Frog Instance;
    public int Code
    {
        get
        {
            return code;
        }
        set { }
    }
    private int code = 1;

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
        MainManager.Instance.ChangeCamera(gameObject.transform.position, Name, "Bonk", _audio, Code);
    }
    // Start is called before the first frame update
    void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
        _audio.enabled = false;
        Size = 2;
        Name = "Frog";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
