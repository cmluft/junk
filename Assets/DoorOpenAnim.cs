using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenAnim : MonoBehaviour {

    Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        anim.Play("Door_Open");

    }
	
	// Update is called once per frame
	void DoorOpen()
    {
        
       
    }
}
