using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PlayerControllerM : MonoBehaviour
{

    public float speed = 10f;
    public float rotationSpeed;
    public float xRange = 33;
    public float zRange = 20;
    private Rigidbody playerRb;
    //private PlayerControllerM playerControllerScript;
    public float powerupStrength;
    public bool hasPowerup;
    public bool isWalking;
    public bool gameOver = false;
    private bool canAttackPrefab = true;
    bool isMovementPressed;
    public int score;
    public int pointValue;
    public int attackStartTime = 0;
    public GameObject powerupIndicator;
    public GameObject attackPrefab;
    public int difficulty;
    public Animator playerAnim;
    private PlayerInput playerInput;
    private Vector3 movementDirection;
    private CharacterController controller;
    public float rotation;
    //private float jumpHeight = 1.0f;
    //private float gravityValue = -9.81f;



    public TextMeshProUGUI scoreText;







    // Start is called before the first frame update
    void Start()
    {
   
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerInput = GetComponent<PlayerInput>();
        controller = gameObject.AddComponent<CharacterController>();
        
    }

    

    // Update is called once per frame
    void Update()
    {

        MovePlayer();
        ConstrainPlayerPosition();
        HandleAnimation();



        


        //Mobile Movement Controls
        Vector2 input = playerInput.actions["Move"].ReadValue<Vector2>();
        Vector3 movementDirection = new Vector3(input.x, 0, input.y);
        controller.Move(movementDirection * Time.deltaTime * speed);


        if (movementDirection != Vector3.zero)
        {
            gameObject.transform.forward = movementDirection;
        }

        isWalking = controller.isGrounded;
        if (isWalking && movementDirection.y < 0)
        {
            movementDirection.y = 0f;
        }

        isMovementPressed = input.x != 0 || input.y != 0;



        // While space is pressed, spawn traffic cone
        if (Input.GetKeyDown(KeyCode.Space) && canAttackPrefab)
            {
                Instantiate(attackPrefab, transform.position, attackPrefab.transform.rotation);
                canAttackPrefab = false;
                StartCoroutine(AttackCountdownRoutine());
                Debug.Log("Player attacks.");
            }

        // While button is pressed, spawn traffic cone
        if (playerInput.actions["Attack"].triggered && canAttackPrefab)
        {
            Instantiate(attackPrefab, transform.position, attackPrefab.transform.rotation);
            canAttackPrefab = false;
            StartCoroutine(AttackCountdownRoutine());
            Debug.Log("Player attacks.");
        }
    }

    IEnumerator AttackCountdownRoutine()
    {
        yield return new WaitForSeconds(3);
        canAttackPrefab = true;
        Debug.Log("Can attack again.");
    }

    // Moves Player or Cursor
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        isMovementPressed = horizontalInput != 0 || verticalInput != 0;
        playerAnim.SetBool("isMovementPressed", isMovementPressed);

    }


    // Keeps Player or Cursor in bounds
    void ConstrainPlayerPosition()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }

    void HandleAnimation()
    {
        bool hasPowerup = playerAnim.GetBool("hasPowerup");
        bool isWalking = playerAnim.GetBool("isWalking");

        if (isMovementPressed && !isWalking)
        {
            playerAnim.SetBool("isWalking", true);
        }
        else if (!isMovementPressed && isWalking)
        {
            playerAnim.SetBool("isWalking", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player has collided with enemy.");
        }

        if (collision.gameObject.CompareTag("Friendly"))
        {
            Debug.Log("Player has collided with friendly.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            speed = (speed + powerupStrength);
            playerAnim.SetBool("hasPowerup", true);
            StartCoroutine(PowerupCountdownRoutine());
            Debug.Log("Powerup effect has begun.");
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(10);
        hasPowerup = false;
        playerAnim.SetBool("hasPowerup", false);
        speed = (speed - powerupStrength);
        Debug.Log("Powerup effect has expired.");
    }

}
