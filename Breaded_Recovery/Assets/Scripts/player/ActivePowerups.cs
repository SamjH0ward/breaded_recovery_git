using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePowerups : MonoBehaviour
{
    public bool DoubleFireActive;
    [SerializeField] private DoubleFire Double;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnEnable() => Double.DoubleFireActive += Activate;

    private void OnDisable() => Double.DoubleFireActive -= Activate;
    private void Activate()
    {
        DoubleFireActive = true;
        StartCoroutine("Length");
    }
    IEnumerator Length()
    {
        yield return new WaitForSeconds(5);
        DoubleFireActive = false;
    }
}
