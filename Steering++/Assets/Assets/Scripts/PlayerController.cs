using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rig; 

    void Awake()
    {
        rig = GetComponent<Rigidbody>(); 
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;


        rig.velocity = new Vector3(x, rig.velocity.y, z);
    }

}
