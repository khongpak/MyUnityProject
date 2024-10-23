using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorScripts : MonoBehaviour
{
    Vector3 v1 = new Vector3(3, 4, 0);
    Vector3 v2 = new Vector3(0, 0, 0);
    void Start()
    {
        Vector3 v3 = v1 - v2;
        float distance = v3.magnitude; 
        float distance2 = Vector3.Distance(v1, v2);
        Debug.Log("V1 : " + v1);
        Debug.Log("V2 : " + v2);
        Debug.Log("V3 : " + v3);
        Debug.Log("Distance :" + distance);
        Debug.Log("Distance2 : " + distance2);
    }

}
