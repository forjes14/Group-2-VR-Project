using UnityEngine;
using System.Collections;

public class ControllerInput : MonoBehaviour {

    private SteamVR_TrackedObject trackedObject;
    private SteamVR_Controller.Device device;
    private ControllerCollisionLisener controllerCollisionLisener;
    private SwordInHand swordInHandScript;
    private GameManager gameManager = GameObject.FindGameObjectWithTag("Camera").GetComponent<GameManager>();

    public static bool swordStart = false;

    private bool _swordInHand;
    // Use this for initialization
    void Start () {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
        controllerCollisionLisener = GetComponent<ControllerCollisionLisener>();
        swordInHandScript = GetComponent<SwordInHand>();
        _swordInHand = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        device = SteamVR_Controller.Input((int)trackedObject.index);

        if (controllerCollisionLisener.GetCanPickUpSword()) PickUpSword();

    }

    private void PickUpSword()
    {
        if (!device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger) && !_swordInHand) return;
            Debug.Log("btn Downs");
            _swordInHand = !_swordInHand;
            swordInHandScript.enabled = _swordInHand;
            swordStart = true;
            gameManager.startGame = true;
    }
}
