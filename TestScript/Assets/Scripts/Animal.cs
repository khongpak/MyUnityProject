using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;
    protected string description;
    protected int animalAge;

    public virtual void AnimalSound()
    {
        animalName = "My name is :";
        description = "My sound is :";
        animalAge = 100;

    }

    protected abstract void AnimalRun();
    

}
