/*
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;
    public float MovementSpeed =1;
    public float Gravity = 9.8f;
    private float velocity = 0;
    public float horizontalSpeed = 10f;
    // vertical rotation speed
    public float verticalSpeed = 10f;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // player movement - forward, backward, left, right
        float horizontal = Input.GetAxis("Horizontal") * MovementSpeed;
        float vertical = Input.GetAxis("Vertical") * MovementSpeed;
        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;

        //characterController.Move((Vector3.right * horizontal + Vector3.forward * vertical) * Time.deltaTime);
        characterController.Move((Vector3.right * mouseY + Vector3.forward * mouseX) * Time.deltaTime);

        // Gravity
        if (characterController.isGrounded)
        {
            velocity = 0;
        }
        else
        {
            velocity -= Gravity * Time.deltaTime;
            characterController.Move(new Vector3(0, velocity, 0));
        }
    }
}
*/

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private CharacterController controller;
    private Rigidbody rb;
    public float move_speed = 7f;
    private Camera cmra;
    
    public float sensX, sensY;
    public float xRotation, yRotation;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        cmra = GetComponentInChildren(typeof(Camera)) as Camera;
    }
    /*
        Update planning

        1. Get where the camera is looking
        2. Move relative to that
       
     
     */
    void Update()
    {
        // Debug.Log(cmra.transform.forward);

        //camera_look_loc = camera_look_loc.normalized;
        Vector3 capsule_pos = transform.position;
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
     
        xRotation += mouseX;
        yRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        Debug.Log(Camera.main.transform.forward);
        //transform.rotation = Quaternion.Euler(xRotation, yRotation, wallRun.tilt);
        transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward, Camera.main.transform.up);
        //rotate()
        transform.Rotate(Camera.main.transform.forward.x, 0, Camera.main.transform.forward.y);

    }
}

