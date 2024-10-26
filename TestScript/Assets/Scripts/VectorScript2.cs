using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorScript2 : MonoBehaviour
{
    public GameObject capsule;
    public GameObject human;
    Vector3 direction;
 
    void Update()
    {
        direction = capsule.transform.position - human.transform.position;
        float angleOfRotation = Vector3.Angle(human.transform.forward, direction);
        
    }
}
