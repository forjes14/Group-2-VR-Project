using UnityEngine;
using System.Collections;

public class SwordInHand : MonoBehaviour {
    private GameObject sword;

    

    // Use this for initialization
    void Start () {
        sword = GameObject.Find("/Stone/SverdTest");
        sword.transform.parent = this.transform;
        //sword.transform.position = this.transform.position;

        //Vector3 pos = new Vector3(-0.5f, 0, -0.4f);
        //Quaternion qua = new Quaternion(90f, 0, 0, 0);
        //sword.transform.position = pos;
        //sword.transform.rotation = qua;
        //sword.transform.position = new Vector3(-0.5f, 0, -0.4f);
        //sword.transform.rotation = new Quaternion(90f,0,0,0);
	}
	
	// Update is called once per frame
	void Update () {

    }
}
