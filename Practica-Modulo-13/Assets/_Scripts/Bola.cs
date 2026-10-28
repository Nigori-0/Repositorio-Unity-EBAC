using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public bool isgamestarted = false;
    [SerializeField] public float velocidadbola = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 posicioninicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicioninicial.y += 3;
        this.transform.position = posicioninicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)|| Input.GetButton("Submit"))

        if(Input.GetKey(KeyCode.Space))
        {
            if(!isgamestarted)
            {
                isgamestarted = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity=velocidadbola * Vector3.up;
            }
        }
    }
}
