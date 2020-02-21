using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public float velocidad;
    public float velocidadSalto;
    public Rigidbody rb;
    private bool enPlataforma;
    private Vector3 posicionInicial;
    public Score s;

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }
    void Update()
    {
        if (enPlataforma && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0f, velocidadSalto, 0f);
            enPlataforma = false;
        }

        float h = velocidad * Input.GetAxis("Horizontal");

        transform.Translate(h * Time.deltaTime, 0, 0, Space.World);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plataforma"))
        {
            enPlataforma = true;
        }

        if(collision.gameObject.name == "End")
        {
            transform.position = posicionInicial;
            s.setScore(5);
        }
    }
}
