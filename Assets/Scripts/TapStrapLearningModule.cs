using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TapStrapLearningModule : MonoBehaviour
{
    public Text testPhrase ;
    public TextMeshProUGUI sample;
    public Dictionary<char, List<int>> tapStrap = new Dictionary<char, List<int>>();
    public List<GameObject> fingers;
    public List<KeyCode> keys = new List<KeyCode>();
    private List<string> keyStrings = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        tapStrap.Add('a', new List<int> { 1, 0, 0, 0, 0 });
        tapStrap.Add('e', new List<int> { 0, 1, 0, 0, 0 });
        tapStrap.Add('i', new List<int> { 0, 0, 1, 0, 0 });
        tapStrap.Add('o', new List<int> { 0, 0, 0, 1, 0 });
        tapStrap.Add('u', new List<int> { 0, 0, 0, 0, 1 });

        tapStrap.Add('n', new List<int> { 1, 1, 0, 0, 0 });
        tapStrap.Add('t', new List<int> { 0, 1, 1, 0, 0 });
        tapStrap.Add('l', new List<int> { 0, 0, 1, 1, 0 });
        tapStrap.Add('s', new List<int> { 0, 0, 0, 1, 1 }); 
       
        tapStrap.Add('d', new List<int> { 1, 0, 1, 0, 0 });
        tapStrap.Add('m', new List<int> { 0, 1, 0, 1, 0 });
        tapStrap.Add('z', new List<int> { 0, 0, 1, 0, 1 });
        
        tapStrap.Add('k', new List<int> { 1, 0, 0, 1, 0 });
        tapStrap.Add('b', new List<int> { 0, 1, 0, 0, 1 });
        
        tapStrap.Add('y', new List<int> { 1, 0, 0, 0, 1 });
        tapStrap.Add('w', new List<int> { 1, 0, 1, 0, 1 });

        tapStrap.Add('h', new List<int> { 0, 1, 1, 1, 1 });
        tapStrap.Add('c', new List<int> { 1, 0, 1, 1, 1 });
        tapStrap.Add('v', new List<int> { 1, 1, 0, 1, 1 });
        tapStrap.Add('j', new List<int> { 1, 1, 1, 0, 1 });
        tapStrap.Add('r', new List<int> { 1, 1, 1, 1, 0 });

        tapStrap.Add('g', new List<int> { 1, 0, 1, 1, 0 }); 
        tapStrap.Add('x', new List<int> { 0, 1, 0, 1, 1 });

        tapStrap.Add('f', new List<int> { 1, 1, 0, 1, 0 });
        tapStrap.Add('q', new List<int> { 0, 1, 1, 0, 1 });

        tapStrap.Add('p', new List<int> { 1, 1, 0, 0, 1 }); 
    
        tapStrap.Add(' ', new List<int> { 1, 1, 1, 1, 1 });







        learningModule();

        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private IEnumerator waitForKeyPress()
    {
        Debug.Log("hi");
        foreach (var a in testPhrase.text)
        {
            Debug.Log(a);
            sample.text = "Letter : " + a;
            var fingerList = tapStrap[a];
            for (int i = 0; i < 5; i++)
            {

                if (fingerList[i] == 1)
                {
                   
                    var sphereRenderer = fingers[i].GetComponent<Renderer>();

                    //Call SetColor using the shader property name "_Color" and setting the color to red
                    sphereRenderer.material.SetColor("_Color", Color.red);

                }
            }

            if (a == ' ')
                yield return new WaitUntil(() => (Input.GetKey(KeyCode.Space)));
            else
            {
                yield return new WaitUntil(() => (Input.GetKey(a.ToString().ToLower())));
            }



            foreach (var x in fingers)
            {
                var sphereRenderer = x.GetComponent<Renderer>();

                //Call SetColor using the shader property name "_Color" and setting the color to red
                sphereRenderer.material.SetColor("_Color", Color.white);
            }
            yield return ExecuteAfterTime(0.1f);
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);


    }
        
   public void learningModule()
    {
        foreach (var x in fingers)
        {
            var sphereRenderer = x.GetComponent<Renderer>();

            //Call SetColor using the shader property name "_Color" and setting the color to red
            sphereRenderer.material.SetColor("_Color", Color.white);
        }
        StartCoroutine(waitForKeyPress());
    }
}
