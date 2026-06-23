using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holamundo : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {
        print("paso algo");
      
        Debug.LogWarning("algo salio mas o menos");
        Debug.LogError("salio mal");
    }

    // Update is called once per frame
    void Update()
    {
        x = x + 1;
        Debug.Log(x);
        Debug.Log("hola desde update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("hola desde fixupdate cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("hola desde late update");
    }
    private void OnEnable()
    {
        Debug.LogWarning("objeto desabilitado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("objeto inhabilitado");
    }
}

