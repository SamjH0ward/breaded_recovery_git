using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoubleFire : MonoBehaviour
{
    public static event Action DoubleFireActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D()
    {
        DoubleFireActive?.Invoke();
        Destroy(gameObject);
    }
}
