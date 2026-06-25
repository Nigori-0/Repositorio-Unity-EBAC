using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsulad_es_on : MonoBehaviour
{
    public GameObject PrefabCube;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        Instantiate<GameObject>(PrefabCube);
    }
    private void OnDisable()
    {
        
    }
}
