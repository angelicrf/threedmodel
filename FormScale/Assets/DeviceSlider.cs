using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeviceSlider : MonoBehaviour
{
   
    public GameObject sldTxtOne;
    public GameObject mainSlider;
    public static DeviceSlider instance = null;
    public GameObject sphereOne;
    public float rotateAmount = 100f;
    public Vector2 sldText_one = new Vector2();
    public Vector2 sphr_one = new Vector2();
    public Vector3 sphere_round = new Vector3();
    public Shader sprShader_one;
    void Start()
    {
        mainSlider = GameObject.Find("MainSlider");
        sldTxtOne = GameObject.Find("sldOneTxt");
        sphereOne = GameObject.Find("SphereOne");
        sprShader_one =  Shader.Find("Unlit/Color");
        var initMainSld = mainSlider.GetComponent<Slider>();
      
        if (initMainSld.direction == Slider.Direction.LeftToRight)
        {
            Debug.Log("true");
            sphr_one.x = 1;
            sphr_one.y = 1;
            sphereOne.transform.localScale = sphr_one;
        }
    }
    void Update()
    {
       var tf =  mainSlider.GetComponent<Slider>();
        var sphrColor = sphereOne.GetComponent<Renderer>().material;
        sldText_one.x = 350;
        sldText_one.y = 150;
        sphere_round.x = 3;
        tf.minValue = 1;
        tf.maxValue = 6;
        sldTxtOne.transform.position = sldText_one;
        var dtText = sldTxtOne.GetComponent<Text>();
        string showValueSld = tf.value.ToString();
        dtText.text = showValueSld;
        dtText.fontSize = 18;
        dtText.color = Color.red;
        dtText.fontStyle = FontStyle.Bold;
        
        if(sphrColor.shader != sprShader_one || tf.value > 1)
        {
            sphrColor.shader = sprShader_one;
            sphrColor.color = Color.red;
            sphr_one.x = (float)tf.value;
            sphr_one.y = (float)tf.value;
            sphereOne.transform.localScale = sphr_one;
        }
        if(tf.value == 1)
        {
            sphrColor.color = Color.blue;
        }
        sphereOne.transform.Rotate(sphere_round, 14 * Time.deltaTime);


    }
}
