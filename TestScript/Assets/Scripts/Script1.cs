using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    private Script2 bScripts;
    // Start is called before the first frame update
    void Start()
    {
        bScripts = GameObject.Find("Obj2").GetComponent<Script2>();
        bScripts.setNumberScript2(5);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(bScripts.getNumberScript2());
    }
}
