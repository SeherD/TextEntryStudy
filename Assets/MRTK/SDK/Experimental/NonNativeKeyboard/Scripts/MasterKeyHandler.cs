using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.IO;

public class MasterKeyHandler : Singleton<MasterKeyHandler>
{
    public bool isKeyPressed = false;
    public bool wasDisabled = false;
    public string keyPressedValue = "";
    public Dictionary<string, List<string>> disableKeyDict = new Dictionary<string, List<string>>();
    public GameObject keyAlpha;
    public GameObject space;
    public HashSet<string> disabledKeys;
    // Start is called before the first frame update
    void Start()
    {
        disabledKeys = new HashSet<string>();
        List<string> buttonNames;
        string keyValue = "";
        keyValue = "q";
        buttonNames = new List<string>()
        { "W_Button",
        "A_Button",
        "S_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "w";
        buttonNames = new List<string>()
        { "Q_Button",
        "D_Button",
        "E_Button",
        "A_Button",
        "S_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "e";
        buttonNames = new List<string>()
        { "W_Button",
        "S_Button",
         "D_Button",
          "R_Button",
          "F_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);
        keyValue = "r";
        buttonNames = new List<string>()
        { "E_Button",
        "D_Button",
         "F_Button",
          "T_Button",
            "G_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "t";
        buttonNames = new List<string>()
        { "R_Button",
        "F_Button",
         "G_Button",
          "Y_Button",
          "H_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "y";
        buttonNames = new List<string>()
        { "T_Button",
        "G_Button",
         "H_Button",
          "U_Button",
          "J_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "u";
        buttonNames = new List<string>()
        { "Y_Button",
        "H_Button",
         "J_Button",
          "I_Button",
          "K_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "i";
        buttonNames = new List<string>()
        { "U_Button",
        "J_Button",
         "K_Button",
          "O_Button",
          "L_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "o";
        buttonNames = new List<string>()
        { "I_Button",
        "K_Button",
         "L_Button",
          "P_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "p";
        buttonNames = new List<string>()
        { "O_Button",
        "L_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "a";
        buttonNames = new List<string>()
        { "Q_Button",
        "W_Button",
         "S_Button",
          "Z_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "s";
        buttonNames = new List<string>()
        { "W_Button",
        "A_Button",
         "Z_Button",
          "X_Button",
           "D_Button",
          "E_Button",
          "Q_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "d";
        buttonNames = new List<string>()
        { "W_Button",
        "E_Button",
        "S_Button",
        "Z_Button",
         "X_Button",
          "C_Button",
           "F_Button",
          "R_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "f";
        buttonNames = new List<string>()
        { "R_Button",
        "D_Button",
         "C_Button",
          "V_Button",
           "G_Button",
          "T_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "g";
        buttonNames = new List<string>()
        { "T_Button",
        "F_Button",
         "V_Button",
          "B_Button",
           "H_Button",
          "Y_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "h";
        buttonNames = new List<string>()
        { "Y_Button",
        "G_Button",
         "B_Button",
          "N_Button",
           "J_Button",
          "U_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "j";
        buttonNames = new List<string>()
        { "U_Button",
        "H_Button",
         "N_Button",
          "M_Button",
           "K_Button",
          "I_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "k";
        buttonNames = new List<string>()
        { "I_Button",
        "J_Button",
         "M_Button",
          "L_Button",
          "O_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "l";
        buttonNames = new List<string>()
        { "O_Button",
        "K_Button",
         "P_Button"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "z";
        buttonNames = new List<string>()
        { "A_Button",
        "S_Button",
         "X_Button",
         "Space"
        };
        disableKeyDict.Add(keyValue, buttonNames);
        keyValue = "x";
        buttonNames = new List<string>()
        { "Z_Button",
        "S_Button",
         "D_Button",
          "C_Button",
          
         "Space"

        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "c";
        buttonNames = new List<string>()
        { "X_Button",
        "D_Button",
         "F_Button",
          "V_Button",
          "Space"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "v";
        buttonNames = new List<string>()
        { "C_Button",
        "F_Button",
         "G_Button",
          "B_Button",
           "Space"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "b";
        buttonNames = new List<string>()
        { "V_Button",
        "G_Button",
         "H_Button",
          "N_Button",
           "Space"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "n";
        buttonNames = new List<string>()
        { "B_Button",
        "H_Button",
         "J_Button",
          "M_Button",
           "Space"
        };
        disableKeyDict.Add(keyValue, buttonNames);

        keyValue = "m";
        buttonNames = new List<string>()
        { "N_Button",
        "J_Button",
         "K_Button",
          "L_Button",
           "Space"
        };
        keyValue = "Space";
        buttonNames = new List<string>()
        { "Z_Button",
            "X_Button",
            "C_Button",
            "V_Button",
            "B_Button",
            "N_Button",
        "M_Button"
        
          
        };
        disableKeyDict.Add(keyValue, buttonNames);




    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isKeyPressed)
        {
            if (disableKeyDict.ContainsKey(keyPressedValue))
            {
                foreach (var disable in disableKeyDict[keyPressedValue])
                {
                    disabledKeys.Add(disable);
                    if (disable.Equals("Space"))
                    {
                        space.SetActive(false);
                    }
                    else
                    keyAlpha.transform.Find(disable).gameObject.SetActive(false);
                }

            }
          

        }
        else
        {
            
                foreach (var disable in disabledKeys)
                {
                    if (disable.Equals("Space"))
                    {
                        space.SetActive(true);
                    }
                    else
                        keyAlpha.transform.Find(disable).gameObject.SetActive(true);
                }

            
            keyPressedValue = "";
        }
      

    }

    












}
