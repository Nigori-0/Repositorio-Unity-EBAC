using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public abstract class PuntajePersistente : ScriptableObject
{
   public virtual void Guardar(string NombreArchivo=null)
    {
        var bf = new BinaryFormatter();
        var file = File.Create(ObtenerRuta(NombreArchivo));
        var json = JsonUtility.ToJson(this);

        bf.Serialize(file, json);
        file.Close();
    }

    public void Cargar(string nombreArchivo = null)
    {
        var bf = new BinaryFormatter();
        var archivo = File.Open(ObtenerRuta(nombreArchivo), FileMode.Open);
        JsonUtility.FromJsonOverwrite((string)bf.Deserialize(archivo), this);
        archivo.Close();
    }

    public string ObtenerRuta(string nombreArchivo=null)
    {
        var nombreArchivoCompleto = string.IsNullOrEmpty(nombreArchivo) ? name : nombreArchivo;
        return string.Format("{0}/{1}.brick,", Application.persistentDataPath, nombreArchivoCompleto);
    }
}
