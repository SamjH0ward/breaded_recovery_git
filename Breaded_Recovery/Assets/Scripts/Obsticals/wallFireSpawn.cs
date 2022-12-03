// aurtour tom

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallFireSpawn : MonoBehaviour
{
    private GameObject Fire1;
    private GameObject Fire2;
    private GameObject Fire3;
    private GameObject Fire4;
    private GameObject Fire5;
    private GameObject Fire6;
    private GameObject Fire7;
    private GameObject Fire8;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Fire1 = GameObject.Find("Fire1");
        Fire2 = GameObject.Find("Fire2");
        Fire3 = GameObject.Find("Fire3");
        Fire4 = GameObject.Find("Fire4");
        Fire5 = GameObject.Find("Fire5");
        Fire6 = GameObject.Find("Fire6");
        Fire7 = GameObject.Find("Fire7");
        Fire8 = GameObject.Find("Fire8");
        

        int gap = Random.Range(1, 9);

        switch (gap)
        {
            case 1:
                Destroy(Fire1);
                break;
            case 2:
                Destroy(Fire2);
                break;
            case 3:
                Destroy(Fire3);
                break;
            case 4:
                Destroy(Fire4);
                break;
            case 5:
                Destroy(Fire5);
                break;
            case 6:
                Destroy(Fire6);
                break;
            case 7:
                Destroy(Fire7);
                break;
            case 8:
                Destroy(Fire8);
                break;
            default:
                Destroy(gameObject);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
