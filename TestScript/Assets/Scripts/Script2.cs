using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    private int numberScript2;
    // Start is called before the first frame update
    void Start()
    {
        numberScript2 = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setNumberScript2(int number)
    {
       numberScript2 = 100+number;

    }

    public int getNumberScript2()
    {
        return numberScript2;
    }
}
