using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveZ, moveX, gravity, fallspeed, jumpvalue;
    public LayerMask whatisground;
    public bool grounded;
    public float rotatespeed;
    public float rotationX, rotationY = 0;
    public CharacterController control;
    Vector3 movedir;
    public float movsped;
    public Transform Cam;
    private void Start()
    {
        // makes so that the cursor is not visible in the game
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        cameracontroler();
        playmove();
        fallingandjumping();
    }

    private void fallingandjumping()
    {
        // if input and the bool grounded is true fallspeed becomes jumpvalue instead
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            fallspeed = jumpvalue;
        }


        // fallspeed becomes fallspeed - gravity times time.deltatime
        fallspeed -= gravity * Time.deltaTime;
        //the bool grounded is active when the raycast shoots down 2 meters and checks if the layer ground is there
        grounded = Physics.Raycast(transform.position, Vector3.down, 2, whatisground);
        // if grounded and the fallspeed is less than 0 fallspeed is equal to 0
        if (grounded && fallspeed < 0) { fallspeed = 0f; }
        //makes the character that the controler sits on move fallspeed times time.deltatime
        control.Move(new Vector3(0, fallspeed * Time.deltaTime, 0));
    }

    private void playmove()
    {
        // makes moveX and MoveZ into the axis horizontal and vertical
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
        // makes the vector3 movedir equal to the direction forward times moveZ and right times moveX
        movedir = transform.forward * moveZ + transform.right * moveX;
        // makes the control move like the vector3 movedir times time.deltatime and times movsped so i can assign any desirable speed
        control.Move(movedir * Time.deltaTime * movsped);

    }

    private void cameracontroler()
    {// horizontal
        rotationX = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, rotationX * rotatespeed, 0));
        // vertical
        rotationY -= Input.GetAxis("Mouse Y");
        // makes rotationY can only go between the numbers -75 and 75
        rotationY = Mathf.Clamp(rotationY, -75, 75);
        // the cams localrotation equal to quaternion and turn the quaternion into a euler and the asigns the rotation to X
        Cam.localRotation = Quaternion.Euler(rotationY, 0, 0);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("hideable"))
        {
            print("sus");

        }


    }

}
