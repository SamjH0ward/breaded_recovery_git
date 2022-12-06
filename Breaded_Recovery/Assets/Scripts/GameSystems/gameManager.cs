// author sam howard

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update

    private static gameManager _instance;
    public static gameManager Instance { get { return _instance; } }

    private HealthSystem playrHealth;

    private Transform spawnRotation;

    [SerializeField] [Range(1,2)] private float enemySpawnRate = 1;
    private float nextSpawnTime;

    [SerializeField] 
    private GameObject[] enmies;

    private int enemyID;
    private float ySpawnLocation;


    private void Awake()
    {
       

        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    void Start()
    {

        
        Debug.Log(playerStats.shipType);
   

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawnTime)
        {
            enemyID = Random.RandomRange(0, 4);
            ySpawnLocation = Random.RandomRange(-4.2f, 4.2f);

            var sawnPoint = Instantiate(enmies[enemyID], (new Vector2(9.7f, ySpawnLocation)), enmies[enemyID].transform.rotation);
            nextSpawnTime = Time.time + (1 / enemySpawnRate);
        }   
        
    }
}
