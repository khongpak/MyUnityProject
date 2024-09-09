using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody bulletRb;
    [SerializeField] float bulletForce = 20.0f;
    [SerializeField] ParticleSystem bomExplosionParticle;
    //[SerializeField] float bulletSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletRb.AddForce(Vector3.forward*bulletForce,ForceMode.Force);
        //transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z + 0.1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BoundDestory"))
        {
            Destroy(gameObject);
        }
    }

   
}
