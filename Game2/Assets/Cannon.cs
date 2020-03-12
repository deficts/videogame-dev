using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cannon : MonoBehaviour
{
    public GameObject original;
    public Transform referencia;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            Instantiate(original, referencia.position, referencia.rotation).gameObject.tag="Proyectil1";
        }


        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(-v * 5 * Time.deltaTime, 0, 0);
        transform.Rotate(h * 200 * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Vacio" || collision.gameObject.tag == "Proyectil2")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
