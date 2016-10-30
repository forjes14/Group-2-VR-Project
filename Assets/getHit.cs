using UnityEngine;
using System.Collections;

public class getHit : MonoBehaviour {

    GameObject highscoreObject;

    // Use this for initialization
    void Start () {
        highscoreObject = GameObject.FindGameObjectWithTag("Manager");
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "weapon")
        {
            highscoreObject.GetComponent<GameManager>().highscore += 10;
            Debug.Log("Highscore = " + highscoreObject.GetComponent<GameManager>().highscore);
            Destroy(this.gameObject);
        }
        else if (other.gameObject.tag == "tower")
        {
            //Stuff
        }
        else
        {
            StartCoroutine(destroyWithOffset(1.5f));
        }
    }

    private  IEnumerator destroyWithOffset(float delay)
    {
        yield return new WaitForSeconds(delay); 
        Destroy(this.gameObject);
    }

}
