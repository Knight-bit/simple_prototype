using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract void Sound();
    private float limit_size = 0.5f;
    protected float size = 1;
    protected string _name;
    public float Size
    {
        get { return size; }
        set
        {
            if (value < limit_size) size = limit_size;
            else size = value;
        }
    }
    public string Name
    {
        get { return _name; }
        set
        {
            if (value != "") _name = value;

        }
    }
    

}
