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

    [SerializeField] protected HealthSystem healthUpdate;
    [SerializeField] private HealthSystem playerHealth;

    [SerializeField] private TextMeshProUGUI health_Ui;

    private Transform spawnRotation;

    [SerializeField] [Range(1,2)] private float enemySpawnRate = 1;
    private float nextSpawnTime;

    [SerializeField] 
    private GameObject[] enmies;

    private int fireSpawn;

    private int enemyID;
    private float ySpawnLocation;


    
    private void Awake()
    {
        //updates health on wake
        health_Ui.text = "Health: " + playerHealth.HitPoints;
        //assures only one instance of gamemanger can exists
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

    }

    // Update is called once per frame
    void Update()
    {
        fireSpawn = Random.Range(1, 1500);
        if (fireSpawn == 137)
        { 
            if (GameObject.FindGameObjectsWithTag("firey").Length == 0)

            {
                Instantiate(enmies[5]);

            }

        }
        if(Time.time > nextSpawnTime)
        {
            //generate a random numebr between 1 and 100 + does not over spawn sniper enemy
            if(GameObject.FindGameObjectsWithTag("sniper").Length >= 5)
            {
               Debug.Log("Max snuper reached");
               enemyID = Random.RandomRange(1, 80);
            }else enemyID = Random.RandomRange(1, 100);

            //generate enemy depending on number generaded
            if(enemyID <= 20)
            {
                enemyID = 0;
            }else if(enemyID <= 40)
            {
                enemyID = 1;
            }else if(enemyID <= 60)
            {
                enemyID = 2;
            }else if(enemyID <= 80)
            {
                enemyID = 3;
            }
            else
            {
                enemyID = 4;    
            }

            //generates random spawn location from the enemy in a given rnage
            ySpawnLocation = Random.RandomRange(-4.2f, 4.2f);

            //spawns the enemy
            Instantiate(enmies[enemyID], (new Vector2(9.7f, ySpawnLocation)), enmies[enemyID].transform.rotation);
            //sets spawn delay for next enemy
            nextSpawnTime = Time.time + (1 / enemySpawnRate);
        }

        
    
        
    }
    private void OnEnable() => healthUpdate.OnHealthChanged += upDateHealthUi;
    private void OnDisable() => healthUpdate.OnHealthChanged -= upDateHealthUi;

    private void upDateHealthUi()
    {
        health_Ui.text = "Health: " + playerHealth.HitPoints;
        if(playerHealth.HitPoints <= 0) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }
    
    
}
