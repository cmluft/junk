using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    public Transform PlayerTransform;
    private Vector3 _cameraOffset;

    [Range(.01f, 1.0f)]
    public float Smoothfactor;

    public bool LookAtPlayer = false;

	// Use this for initialization
	void Start () {
        _cameraOffset = transform.position - PlayerTransform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 newpos = PlayerTransform.position + _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newpos, Smoothfactor);

        if (LookAtPlayer)
        {
            transform.LookAt(PlayerTransform);
        }
	}
}
