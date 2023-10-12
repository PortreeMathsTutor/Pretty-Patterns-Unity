using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAwayFromCenter : MonoBehaviour
{
    float rSquared;
    float amount;
    Rigidbody m_Rigidbody;
    private GameObject center;
    void Start()
    {
        amount = -0.1f;
       center = GameObject.Find("Center");
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
      
        rSquared = (transform.position.x * transform.position.x) + (transform.position.y * transform.position.y)+ (transform.position.z * transform.position.z);
        if (rSquared<15) 
        { 
            amount = -6f;
            m_Rigidbody.AddForce(transform.up * 6);
        }
        if (rSquared >160) { amount =2f; }
     
            transform.LookAt(center.transform.position);
            m_Rigidbody.AddForce(transform.forward * amount);
            transform.rotation = Quaternion.identity;
      
     
    }
}
