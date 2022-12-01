using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update

    private static gameManager _instance;
    public static gameManager Instance { get { return _instance; } }

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


        Instantiate(enmies[Random.RandomRange(0, 4)], new Vector2(0,0),new Quaternion(0,0,-0.5f,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
