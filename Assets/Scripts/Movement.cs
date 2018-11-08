using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float m_Speed;
    

    void Start()
    {
        
        m_Speed = 10.0f;
       
    }

    void Update()
    {
        
        
            transform.Translate(Input.GetAxis("Horizontal") * m_Speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * m_Speed * Time.deltaTime);

        
        

    }



}

    