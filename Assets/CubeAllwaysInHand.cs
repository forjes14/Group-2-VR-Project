using UnityEngine;
using System.Collections;
//[ExecuteInEditMode]
public class CubeAllwaysInHand : MonoBehaviour {
    public GameObject rightHandObject;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(rightHandObject.transform.position.x, rightHandObject.transform.position.y, rightHandObject.transform.position.z);
        transform.rotation = new Quaternion(rightHandObject.transform.rotation.x, rightHandObject.transform.rotation.y, rightHandObject.transform.rotation.z, rightHandObject.transform.rotation.w);
	}
}
