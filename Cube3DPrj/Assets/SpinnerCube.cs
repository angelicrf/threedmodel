using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerCube : MonoBehaviour
{
    public Vector3 rotateCount;
    void Start()
    {
        
    }
    void Update()
    {
        rotateCount.y = 3;
        rotateCount.x = 3;
        transform.Rotate(rotateCount);
    }
}
