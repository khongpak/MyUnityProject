using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float enemySpeed;
    [SerializeField] private ParticleSystem bomExplosionParticle;
    [SerializeField] AudioClip boomSoundEffect;

    private AudioSource enemyAudioSource;
    
    private GameManager gameManager;
    void Start()
    {
        enemySpeed = Random.Range(0.02f, 0.06f);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        enemyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - enemySpeed, transform.position.y,transform.position.z);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("Enemy was shot");
            gameManager.AddScore();
            bomExplosionParticle.Play();
            enemyAudioSource.PlayOneShot(boomSoundEffect, 4);
            Destroy(other.gameObject);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BoundDestory"))
        {
            Destroy(gameObject);
        }
    }
}
