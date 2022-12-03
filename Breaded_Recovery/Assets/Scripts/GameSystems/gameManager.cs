// aurtour sam howard

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

    [SerializeField] 
    private GameObject[] enmies;


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

        //int enemyID = Random.RandomRange(0, 4);
        // var sawnPoint = Instantiate(enmies[enemyID], (new Vector2(0,0)),  enmies[enemyID].transform.rotation);
        Debug.Log(playerStats.shipType);
   

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
