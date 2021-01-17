using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    Rigidbody rb;
    public static Vector3 dVelocity;

    public Text text;

    public static float number = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        dVelocity = rb.velocity;
        
        text.text = number.ToString();

        if (Input.GetMouseButtonDown(0))
        {
            transform.position = new Vector3(0, 4, 0);
            rb.velocity = Vector3.zero;
            float rotX = Random.Range(0, 361) % 90;
            float rotY = Random.Range(0, 361) % 90;
            float rotZ = Random.Range(0, 361) % 90;
            transform.rotation = new Quaternion(rotX, rotY, rotZ, transform.rotation.w);
            float dirX = Random.Range(0, 500);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(0, 500);
            rb.AddForce(transform.up * 500);
            rb.AddTorque(dirX, dirY, dirZ);

        }
    }
}
