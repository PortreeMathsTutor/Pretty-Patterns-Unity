using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeWithHeight : MonoBehaviour
{
    int theTimer = 0;
    public float redChannelValue;
    public float greenChannelValue;
    public float buleChannelValue;
    public float alphaChanelValue;
    float rSquared;
 

    // Update is called once per frame
    void Update()
    {
      
            rSquared = (transform.position.x * transform.position.x) +(transform.position.y * transform.position.y) + (transform.position.z * transform.position.z);
            redChannelValue = rSquared* transform.position.y *0.0001f;
            greenChannelValue = rSquared * transform.position.y*0.0005f;
            buleChannelValue = transform.position.y * 0.1f + 0.1f;
            alphaChanelValue = transform.position.y * 0.1f;
            GetComponent<Renderer>().material.color = new Color(redChannelValue, greenChannelValue, buleChannelValue, alphaChanelValue);
    
    }

}
