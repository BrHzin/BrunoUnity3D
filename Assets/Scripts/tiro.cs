using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour
{
    public Rigidbody obj_shooter;
    public Transform pos_origem;
    public float speed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody shooter_instance;
            shooter_instance = Instantiate(obj_shooter, pos_origem.position, pos_origem.rotation) as Rigidbody;
            shooter_instance.AddForce(pos_origem.forward * speed);
        }
    }
}
