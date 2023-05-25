using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
    public float movespeed = 5;
    public float mousespeed = 5;
    public float maxangle = 70f;
    public float minangle = -70f;
    private float mousehorizontal = 0;
    private float mousevertical = 0;

   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        mousehorizontal += Input.GetAxis("Mouse X") * mousespeed * 1;
        mousevertical -= Input.GetAxis("Mouse Y") * mousespeed * 1;
        mousevertical = Mathf.Clamp(mousevertical,minangle,maxangle);
        Camera.main.transform.localRotation = Quaternion.Euler(mousevertical,mousehorizontal ,0);



        float forwardmove = Input.GetAxis("Vertical");
        float sidemove = Input.GetAxis("Horizontal");

        Vector3 direction = new Vector3 (sidemove,0,forwardmove);

        direction = Camera.main.transform.rotation * direction;

        characterController.SimpleMove(direction * Time.deltaTime * movespeed );
    }
}
