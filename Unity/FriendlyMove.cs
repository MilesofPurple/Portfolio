using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyMove : MonoBehaviour
{
    public float speed = 5.0f;
    public int pointValue;
    public int deathValue;
    private Rigidbody objectRb;
    private float xDestroy = -34.0f;
    private SpawnManagerM spawnManagerM;
    private AudioSource friendlyAudio;
    public ParticleSystem explosionParticle;
    public AudioClip friendlySound;
    public Animator friendlyAnim;


    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
        spawnManagerM = GameObject.Find("Spawn Manager").GetComponent<SpawnManagerM>();
        friendlyAudio = GetComponent<AudioSource>();
        friendlyAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        friendlyAnim.SetBool("hasPowerup", true);
        friendlyAnim.SetBool("isMovementPressed", true);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if(transform.position.x < xDestroy)
        {
            Destroy(gameObject);
            spawnManagerM.UpdateScore(pointValue);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("attackPrefab"))
        {
            Debug.Log("Friendly has collided with Player Attack");
            friendlyAudio.PlayOneShot(friendlySound, 1.0f);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            //Destroy(other.gameObject); 
            Destroy(gameObject);
            spawnManagerM.UpdateScore(deathValue);
        }

        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Friendly has collided with Enemy");
            friendlyAudio.PlayOneShot(friendlySound, 1.0f);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            Destroy(gameObject);
            spawnManagerM.UpdateScore(deathValue);
        }
    }
}
