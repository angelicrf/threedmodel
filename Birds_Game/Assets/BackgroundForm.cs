using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundForm : MonoBehaviour
{
    
    
    void Start()
    {
        var bakground = new GameObject();
        var newTxt = bakground.AddComponent<TextMesh>();
       // var meshRenderer = bakground.AddComponent<MeshRenderer>();

        newTxt.text = "NewText";
        newTxt.color = Color.red;
        newTxt.transform.position = new Vector3(0, 5, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
