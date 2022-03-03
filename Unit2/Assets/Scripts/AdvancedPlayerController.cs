using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedPlayerController : MonoBehaviour
{
    // Code for movement
    public CharacterController controller;
    public Transform cam;

    public float speed = 6f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public bool smoothMover = false;

    // Variables for gravity
    Vector3 velocity;
    public float gravity = -9.81f;

    // Variables for jumping
    public float jumpHeight = 3f;
    public bool allowJumping = true;

    //Variables for the max and min for randomizer
    float minValue = 0f;
    float maxValue = 10f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMover();
        ApplyGravity();
        ProcessJumping();
    }

    //Makes the player bounce up if they collide with an object with the "Bouncy" tag
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Bouncy")
        {
            // Knocks the player up by a random velocity between min and max
            velocity.y = Random.Range(minValue,maxValue);
        }

        if (hit.gameObject.tag == "Slide")
        {
            // Slides the player backwards when on object with slide tag
            velocity.z = -2f;
        }
        // Undos the slide effect when the player should not be sliding
        else if(hit.gameObject.tag == "StopSliding")
        {
            velocity.z = 0f;
        }
    }

    void PlayerMover()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            if (smoothMover)
            {
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);
            }
            else if (!smoothMover)
            {
                transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            }

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
    }

    void ApplyGravity()
    {
        // Code for gravity
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void ProcessJumping()
    {
        if (allowJumping && Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }
}
