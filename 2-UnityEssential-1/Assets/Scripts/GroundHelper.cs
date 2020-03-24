using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundHelper : MonoBehaviour
{
    public GameObject CrystalPrefab;
    GameObject _current;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Creator", Random.Range(1, 100), Random.Range(1, 10));
    }

    void Creator()
    {
        if (_current == null)
        {
            _current = Instantiate(CrystalPrefab, transform.position, Quaternion.identity) as GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
