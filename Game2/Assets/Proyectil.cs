using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(15 *transform.up, ForceMode.Impulse);
        Destroy(gameObject,3);
    }

    // Update is called once per frame
    void Update()
    {   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor") {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
      
    }

}
