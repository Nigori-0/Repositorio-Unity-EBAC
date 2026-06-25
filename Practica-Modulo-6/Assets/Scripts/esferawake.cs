using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esferawake : MonoBehaviour
{
    public GameObject PrefabCube;

    private void Awake()
    {
        Instantiate<GameObject>(PrefabCube);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
