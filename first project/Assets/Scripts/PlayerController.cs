using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
    public float movespeed = 5;
    public float mousespeed = 5;

    private float mousevertical = 0;
    private float mousehorizontal = 0;

   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        mousevertical += Input.GetAxis("Mouse X") * mousespeed * 1;
        mousehorizontal += Input.GetAxis("Mouse Y") * mousespeed * 1;
        Camera.main.transform.localRotation = Quaternion.Euler(mousehorizontal, mousevertical,0);



        float forwardmove = Input.GetAxis("Vertical");
        float sidemove = Input.GetAxis("Horizontal");

        Vector3 direction = new Vector3 (sidemove,0,forwardmove);
        characterController.SimpleMove(direction * Time.deltaTime * movespeed );
    }
}
