using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 80;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0.1f,0);
        transform.Rotate(0,0,1f);
    }
}
