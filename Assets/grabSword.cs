using UnityEngine;
using System.Collections;

public class grabSword : MonoBehaviour {
	private SteamVR_TrackedController controllerDevice;
	// Use this for initialization
	public bool triggerButtonDown = false;

	private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

	private SteamVR_Controller.Device controller
	{

		get
		{
			return SteamVR_Controller.Input((int)trackedObj.index);

		}

	}
	private SteamVR_TrackedObject trackedObj;


	void Start () {
		controllerDevice = GetComponent<SteamVR_TrackedController>();
		if (controllerDevice == null) {
			controllerDevice = gameObject.AddComponent<SteamVR_TrackedController>();
		}
		
	}


	// Update is called once per frame
	void Update () {
		triggerButtonDown = controller.GetPressDown(triggerButton);

		if (triggerButtonDown)
		{

			Debug.Log("Fire");

		}

	}
}
