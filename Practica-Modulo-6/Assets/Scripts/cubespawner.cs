using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubespawner : MonoBehaviour
{
    public GameObject PrefabCube;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos=0;

    // Start is called before the first frame update
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCube);
        tempGameObject.name = "CuboNumero" + numCubos;
    }
}
