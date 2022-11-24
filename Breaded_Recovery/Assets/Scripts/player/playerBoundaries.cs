using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerBoundaries : MonoBehaviour
{

    [SerializeField] private float negX =-8.4f, posX = 8.4f, negY =-4.7f, posY =4.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //negative bondary for y value
        if (transform.position.x < negX)
        {
            transform.position = new Vector2(negX, transform.position.y);
        }
        //posative bondary for x value
        else if (transform.position.x > posX)
        {
            transform.position = new Vector2(posX, transform.position.y);
        }

        //negative bondary for y value
        if (transform.position.y < negY)
        {
            transform.position = new Vector2(transform.position.x, negY);
        }
        //posative bondary for y value
        else if (transform.position.y > posY)
        {
            transform.position = new Vector2(transform.position.x, posY);
        }
    }
}
