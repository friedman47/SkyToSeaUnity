using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {
    public Transform TeleportTgt;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            print(other.tag + " entered the teleporter");
            other.transform.position = TeleportTgt.position;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
