//author Seb
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    public float ScrollingSpeed = 0.5f;
    private Renderer renderer;
    private Vector2 savedOffset;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        savedOffset = new Vector2(0, Time.time*ScrollingSpeed);
        renderer.material.mainTextureOffset = savedOffset;
    }
}
