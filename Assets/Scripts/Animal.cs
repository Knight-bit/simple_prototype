using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract void Sound();
    protected float size;
    protected string name;

}
