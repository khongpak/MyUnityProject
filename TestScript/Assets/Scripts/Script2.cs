using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    private void Start()
    {
        Script1.instance.setScore(15);
        Debug.Log(Script1.instance.score);
    }

}
