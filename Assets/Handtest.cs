using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handtest : MonoBehaviour
{
    public TMPro.TextMeshPro text;
    public RectTransform t;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "pos: " + t.position + "\nrotation: " + t.eulerAngles + "\nscale: " + t.localScale + "\nheight: " + t.rect.height + "\nwidth: " + t.rect.width;
    }

    // Update is called once per frame
    void Update()
    { if (t.hasChanged)
        {
            text.text = "pos: " + t.position + "\nrotation: " + t.eulerAngles + "\nscale: " + t.localScale.ToString("F7") + "\nheight: " + t.rect.height + "\nwidth: " + t.rect.width;
        }
        
    }

    
}
