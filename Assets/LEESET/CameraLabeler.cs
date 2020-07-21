using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CameraLabeler : MonoBehaviour
{
    string content;

    public void ExportText()
    {
        //Path of the file
        string path = Application.dataPath + "/Mapcontent.txt";
        //Create File if it doesn't exist
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "start \n\n");
        }
        //Content of the file
        //Add some to text to it
        File.AppendAllText(path, "12310" + content + "\n");
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
