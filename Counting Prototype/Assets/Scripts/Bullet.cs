using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody bulletRb;
    [SerializeField] float bulletForce = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletRb.AddForce(Vector3.forward*bulletForce,ForceMode.Force);
    }
}
