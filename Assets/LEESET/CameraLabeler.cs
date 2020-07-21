using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CameraLabeler : MonoBehaviour
{
    void CreateText()
    {
        //Path of the file
        string path = Application.dataPath + "/Log.txt";
        //Create File if it doesn't exist
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Login log \n\n");
        }
        //Content of the file
        string content = "Login date: " + System.DateTime.Now + "\n";
        //Add some to text to it
        File.AppendAllText(path, content);
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
