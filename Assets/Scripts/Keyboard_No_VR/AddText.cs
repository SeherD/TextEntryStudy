using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System;


public class AddText : MonoBehaviour
{



public Dictionary<int, string> phrases = new Dictionary<int, string>();


public Text myText;
    // Start is called before the first frame update
    void Start()
    {
        ReadString();
        GenerateNewTestString();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateNewTestString()
    {
        System.Random rd = new System.Random();

        int rand_num = rd.Next(0, 500);
        
        string phrase = "";
        phrases.TryGetValue(rand_num, out phrase);
        myText.text = phrase;
    }
     void ReadString()
    {
        string path = "Assets/Scripts/phrases2.txt";

        string line = "";
        int i = 0;
        StreamReader reader = new StreamReader(path);
        while ((line = reader.ReadLine()) != null)
        {
            phrases.Add(i,line);
            i++;
        }
        reader.Close();
    }
}
