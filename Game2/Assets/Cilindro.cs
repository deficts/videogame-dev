using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilindro : MonoBehaviour
{
    public Transform esfera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("hola");
            transform.RotateAround(esfera.position, Vector3.up, 30 * Time.deltaTime);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.RotateAround(esfera.position, Vector3.down, 30 * Time.deltaTime);
        }
    }
}
