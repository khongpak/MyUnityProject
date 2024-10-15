using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public int nowAge;
    public string aName;
    public string aDes;

    // Start is called before the first frame update
    void Start()
    {
        AnimalSound();
    }

    public override void AnimalSound()
    {
        base.AnimalSound();
        animalName = "I am a :" + aName;
        description = "My sound look like :" + aDes;
        animalAge = animalAge + nowAge;
        Debug.Log("Animal name :" + animalName);
        Debug.Log("Animal Description : " + description);
        Debug.Log("Animal Age : " + animalAge);

    }

    protected override void AnimalRun()
    {

    }
}
