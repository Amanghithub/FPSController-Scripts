using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public CharacterController controller;
    public float movespeed = 10f;

    void Update(){
        float x = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;

        controller.Move(transform.forward * y);
        controller.Move(transform.right * x);
    }
}
