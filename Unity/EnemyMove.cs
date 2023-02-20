using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    public int deathValue;
    public int pointValue;
    private Rigidbody objectRb;
    private float zDestroy = -25.0f;
    private SpawnManagerM spawnManagerM;
    private AudioSource enemyAudio;
    public AudioClip attackSound;
    public ParticleSystem explosionParticle;

        

    // Start is called before the first frame update
    void Start()
    { 
        objectRb = GetComponent<Rigidbody>();
        enemyAudio = GetComponent<AudioSource>();
        //spawnManagerM = GameObject.Find("Spawn Manager").GetComponent<SpawnManagerM>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            Debug.Log("Enemy has collided with Powerup");
            Destroy(other.gameObject);
        }

        if (other.CompareTag("attackPrefab"))
        {
            Debug.Log("Enemy has collided with Player Attack");
            enemyAudio.PlayOneShot(attackSound, 1.0f);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            spawnManagerM.UpdateScore(pointValue);
        }
    }
}
