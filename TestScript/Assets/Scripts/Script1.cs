using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public static Script1 instance { get; private set; }
    public int score { get; private set; } = 10;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;  
        }
        else
        {
            Destroy(gameObject);  
        }
    }

    public void setScore(int setscore)
    {
        score = setscore;
    }

}
