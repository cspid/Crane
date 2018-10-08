using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanSpin : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(18, 0, 0, Space.Self);
	}
}
