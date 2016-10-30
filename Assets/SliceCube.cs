using UnityEngine;
using System.Collections;

public class SliceCube : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        Debug.Log("Start");
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        Destroy(this.gameObject);
    }
}
