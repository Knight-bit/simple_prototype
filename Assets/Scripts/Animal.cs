using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract void Sound();
    private float limit_size = 0.5f;
    public float Size
    {
        get { return size; }
        set
        {
            if (value <= limit_size) size = size;
            else size = value * size;
        }
    }
    protected float size;

    public string Name
    {
        get { return name; }
        set
        {
            if (value == "") name = name;
            else name = value;
        }
    }
    protected string name;

}
