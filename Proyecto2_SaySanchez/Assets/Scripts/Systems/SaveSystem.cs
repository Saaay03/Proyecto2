using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;

public class SaveSystem : MonoBehaviour
{
    public static SaveSystem instance;
    public Leccion data;
    public SubjectContainer subject;
    private void Awake()
    {
        if (instance != null)
        {
            return;
        }
        else
        {
            instance = this;
        }
    }

    private void Start()
    {
        SaveToJSON("LeccionDummy", data);
        //SaveToJSON("SubjectDummy", subject);

        CreateFile("Pepinillo", ".data");

        subject = LoadFromJSON<SubjectContainer>("Archivito");
    }

    public void CreateFile(string fileName, string extension)
    {
        
    }
    
    public void SaveToJSON(string _fileName, object _data)
    { 

    }

    public T LoadFromJSON<T>(string _fileName) where T : new()
    {
        T Dato = new T();
        string path = Application.dataPath + "/Resources/JSONS/" + _fileName + ".json";
        string JSONData = "";
        if (File.Exists(path)) 
        { 
            JSONData = File.ReadAllText(path);
            Debug.Log("JSON STRING: " + JSONData);
        }
        if (JSONData.Length != 0) 
        {
            JsonUtility.FromJsonOverwrite(JSONData, Dato);
        }
        else
        {
            Debug.LogWarning("ERROR - FileSystem: JSONData is empty, check for local variable [string JSONData]");
        }
        return Dato;
    }
}
