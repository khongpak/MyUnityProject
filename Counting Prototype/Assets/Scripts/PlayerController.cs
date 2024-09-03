using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float xRang = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x < -xRang)
        {
            transform.position = new Vector3(-xRang,transform.position.y, transform.position.z);

        }
        if (transform.position.x > xRang)
        {
            transform.position = new Vector3(xRang, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.position = new Vector3(transform.position.x + (horizontalInput * Time.deltaTime * moveSpeed), transform.position.y, transform.position.z);
    }
}
