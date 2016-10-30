using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour {

    public GameObject cube;
    public Vector3 force;
    public float spawnTime;
    private bool startSpawn;

    private GameObject gameManager;
    

	// Use this for initialization
	void Start () {
        startSpawn = false;
        gameManager = GameObject.FindGameObjectWithTag("Camera");
    }
	
	// Update is called once per frame
	void Update () {
        if(gameManager.GetComponent<GameManager>().startGame && !startSpawn)
        {
            startSpawn = true;
            startSpawning();
        }
    }

    void SpawnCube()
    {
        var newCube = GameObject.Instantiate(cube);
      
        //Debug.Log(Random.value);
        newCube.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        Rigidbody rb = newCube.GetComponent<Rigidbody>();
        Vector3 randomly = new Vector3(Random.Range(0f, 35.0f), 0, Random.Range(0, 350f));
        //Debug.Log(randomly.x);
        rb.AddForce(new Vector3(force.x + randomly.x, force.y, force.z));
    }

    void startSpawning()
    {
        if(startSpawn == true)
        {
            InvokeRepeating("SpawnCube", spawnTime, spawnTime);
        }
    }
}
