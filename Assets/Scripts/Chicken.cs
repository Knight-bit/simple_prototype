using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal
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
    private int code = 1;
    public static Chicken Instance;
    public bool is_on = false;
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
        if(!is_on)
        {
            _audio.enabled = true;
            MainManager.Instance.ChangeCamera(gameObject.transform.position, Name, "Cacareo", _audio, Code);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
        _audio.enabled = false;
        Name = "Chicken";
        Size = 1;
    }

}
