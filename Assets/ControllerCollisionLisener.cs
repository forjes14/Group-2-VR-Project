using UnityEngine;
using System.Collections;

public class ControllerCollisionLisener : MonoBehaviour {

    private bool canPickUpSword;

    // Use this for initialization
    void Start () {
        canPickUpSword = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "weapon")
        {
            //Debug.Log("Trigger enter");
            canPickUpSword = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "weapon")
        {
            //Debug.Log("Trigger exit");
            canPickUpSword = false;
        }
    }

    public bool GetCanPickUpSword()
    {
        return canPickUpSword;
    }


}
