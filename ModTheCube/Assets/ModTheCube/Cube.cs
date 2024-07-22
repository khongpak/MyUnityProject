using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 cubeLocation = new Vector3(3, 4, 1);
    public float cubeRotate;
    public float cubeRotateSpeed = 2.0f;
 
    void Start()
    {
        CubeSetting();
    }
    
    void Update()
    {
        transform.Rotate(cubeRotate, cubeRotate, cubeRotate);
    }

    void CubeSetting()
    {
        cubeRotate = Random.Range(0f, 30.0f)*Time.deltaTime*cubeRotateSpeed;

        transform.position = cubeLocation;
        transform.localScale = Vector3.one * 1.3f;

        Material material = Renderer.material;

        
        material.color = new Color(Random.Range(0.1f,1.0f), Random.Range(0.1f, 1.0f), Random.Range(0.1f, 1.0f), Random.Range(0.1f, 1.0f));
    }
}
