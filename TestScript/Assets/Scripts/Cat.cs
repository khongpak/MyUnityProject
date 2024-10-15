using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    public int nowAge;
    public string aName;
    public string aDes;

    void Start()
    {
        AnimalSound(); 
    }

    public override void AnimalSound()
    {
        base.AnimalSound();
        animalName = animalName + aName;
        description = description + aDes;
        animalAge = animalAge + nowAge;
        Debug.Log("Animal name :" + animalName);
        Debug.Log("Animal Description : " + description);
        Debug.Log("Animal Age : " + animalAge);
    }

    protected override void AnimalRun()
    {

    }
}
