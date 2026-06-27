using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go5 : MonoBehaviour
{
    public And cuboAND;
    public Or cuboOR;

    bool valor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        valor = cuboAND.GetComponent<Renderer>().material.color == Color.white &&
                cuboOR.GetComponent<Renderer>().material.color == Color.white;

        if (valor)
            GetComponent<Renderer>().material.color = Color.white;
        else
            GetComponent<Renderer>().material.color = Color.black;
    }
}
