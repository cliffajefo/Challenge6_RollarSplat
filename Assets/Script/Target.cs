using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody TargetRb;
    //private GameManager gameManager;

    private float minspeed = 8;
    private float maxspeed = 15;
    private float maxtorque = 10;
    private float xrange = 4;
    private float SpawnPosy = -2;

    public int pointValue;

    public ParticleSystem explosionParticle;

    
    
    // Start is called before the first frame update
    void Start()
    {
        //TargetRb = GetComponent<Rigidbody>();

        //gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        //TargetRb.AddForce(Randomforce(), ForceMode.Impulse);
        //TargetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        //transform.position = RandomSpawnPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*

    private void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            gameManager.updateScore(pointValue);
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.Gameover();
        }
    }
    */

    Vector3 Randomforce()
    {
        return Vector3.up * Random.Range(minspeed, maxspeed);
    }

    

    float RandomTorque()
    {
        return Random.Range(-maxtorque, maxtorque);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xrange, xrange), -SpawnPosy);
    }
    

}
