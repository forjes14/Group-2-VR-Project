using UnityEngine;
using System.Collections;
using Valve.VR;

public class TestingControllerInput : MonoBehaviour {

	//Public
	public GameObject rightController;
	public GameObject leftController;
	public Mesh swapMesh;

	//Private
	private MeshCollider col;
	private MeshRenderer meshRenderer;
	private SteamVR_RenderModel rightModel;
	private SteamVR_RenderModel leftModel;
	
	// Use this for initialization
	void Start () {
		col = GetComponent<MeshCollider>();
		rightController = GameObject.FindGameObjectWithTag("Right Controller");
		leftController = GameObject.FindGameObjectWithTag("Left Controller");
        Debug.Log("Kontroller Start, GangSta!");
		//rightModel = rightController.GetComponent<SteamVR_RenderModel>();
		//leftModel = leftController.GetComponent<SteamVR_RenderModel>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    void onTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
    }

	//Runs everyframe this mesh collider is in another meshcollider
	//void OnCollisionStay(Collision collisionInfo)
	//{

	//	////Skulle liksom prøve å endre mesh i koden. MER JOBBING HER
	//	//Debug.Log("Collision with:" + collisionInfo.gameObject.tag.ToString());
	//	//if (SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Leftmost)).GetHairTriggerDown())
	//	//{
	//	//	if(collisionInfo.gameObject.tag.Equals("weapon"))
	//	//	{
	//	//		Debug.Log("left controller in sword");
	//	//	}
	//	//} else if (SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Rightmost)).GetHairTriggerDown())
	//	//{
	//	//	if (collisionInfo.gameObject.tag.Equals("weapon"))
	//	//	{
	//	//		Debug.Log("right controller in sword");
	//	//	}
	//	//}
	//}
	
}
