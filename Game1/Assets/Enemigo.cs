using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float direccion = 1;
    public float velocidad;
    public Score s;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(direccion*velocidad*Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("colision");
        direccion *= -1;
    }
    private void OnTriggerEnter(Collider other)
    {
        direccion *= -1;
        if (other.name == "Monito")
        {
            s.setScore(-1);
        }
    }
}
