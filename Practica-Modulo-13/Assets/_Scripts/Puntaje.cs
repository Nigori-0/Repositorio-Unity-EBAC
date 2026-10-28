using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform transformRecord;
    public Transform transformPuntaje;
    public TMP_Text textoRecord;
    public TMP_Text textoPuntaje;
    public Records recordSO;
    //public int puntos=0;
    //public int record=10000;
    // Start is called before the first frame update
    void Start()
    {
        //transformPuntaje = GameObject.Find("Puntaje").transform;
        //transformRecord = GameObject.Find("Record").transform;
        textoPuntaje = transformPuntaje.GetComponent<TMP_Text>();
        textoRecord = transformRecord.GetComponent<TMP_Text>();
        //if(PlayerPrefs.HasKey("Record"))
        //{
        // record = PlayerPrefs.GetInt("Record");
        // }
        recordSO.Cargar();
        textoRecord.text = $"Record: {recordSO.record}";
        recordSO.puntaje = 0;
    }

    private void FixedUpdate()
    {
        recordSO.puntaje += 50;
    }

    // Update is called once per frame
    void Update()
    {
        textoPuntaje.text = $"Puntaje: {recordSO.puntaje}";
        if (recordSO.puntaje>recordSO.record)
        {
            recordSO.record = recordSO.puntaje ;
            textoRecord.text = $"Record:{recordSO.record}";
            recordSO.Guardar();
            //PlayerPrefs.SetInt("Record", puntos);
        }
    }
}
