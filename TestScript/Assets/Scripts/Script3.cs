using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    string playerName = "Frank";

    List<GameObject> objectList = new List<GameObject>();
    
    Dictionary<string, GameObject> objectDict = new Dictionary<string, GameObject>();
    bool isTrue = true;

    void Start()
    {
        Debug.Log("Hello: " + gameObject.name + playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 
}
