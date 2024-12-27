using System;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 3f;
    static float jumpForce = 4f;

    static Vector3 moveVector;

    AudioSource source;

    public float sensitivity = 10f;
    public float maxYAngle = 80f;

    float allowJump;

    public static bool isGround = true;

    Rigidbody rb;

    Thread jumpThread;

    void Start()
    {
        transform.position = new Vector3(288.279999f, 15.8400002f, 50.1800003f);

        rb = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();

        moveVector = Vector3.zero;

        allowJump = 0;
    }

    void Update()
    {
        float xAxis = Input.GetAxisRaw("Horizontal") * speed;
        float zAxis = Input.GetAxisRaw("Vertical") * speed;

        moveVector = new Vector3(xAxis, 0f, zAxis);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 4f;
        }
        else
        {
            speed = 3f;
        }
    }

    private void FixedUpdate()
    {
        Vector3 moveTransform = transform.TransformDirection(moveVector) * speed;

        rb.velocity = new Vector3(moveTransform.x, rb.velocity.y, moveTransform.z);

        if (Input.GetKey(KeyCode.Space))
        {
            Invoke("jump", 0.1f);
        }
    }
    void onGround()
    {
        isGround = true;
    }

    void offGround()
    {
        isGround = false;
    }

    void jump()
    {
        if (isGround && Time.time > allowJump)
        {
            Vector3 targetForce = Vector3.up * jumpForce;
            rb.AddForce(targetForce, ForceMode.VelocityChange);

            allowJump = Time.time + 0.2f;
        }
    }
}