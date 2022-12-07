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

    private int enemyID;
    private float ySpawnLocation;


    private void Awake()
    {
        health_Ui.text = "Health: " + playerHealth.HitPoints;

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
    private void OnEnable() => healthUpdate.OnHealthChanged += upDateHealthUi;
    private void OnDisable() => healthUpdate.OnHealthChanged -= upDateHealthUi;

    private void upDateHealthUi()
    {
        health_Ui.text = "Health: " + playerHealth.HitPoints;
    }
    
    
}
