using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cannon2 : MonoBehaviour
{
    public GameObject original;
    public Transform referencia;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.M))
        {
            Instantiate(original, referencia.position, referencia.rotation).gameObject.tag="Proyectil2";
        }

        if (Input.GetKey(KeyCode.I))
        {
            transform.Translate(-velocidad * 5 * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.Translate(velocidad * 5 * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.J)){
            transform.Rotate(-velocidad * 200 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.L)){
            transform.Rotate(velocidad * 200 * Time.deltaTime, 0, 0);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        print("collision.gameObject.tag");
        print("hola");
        if (collision.gameObject.tag == "Vacio" || collision.gameObject.tag == "Proyectil1")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
