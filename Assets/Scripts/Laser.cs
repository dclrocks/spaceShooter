using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    //speed variable of 8
    [SerializeField] private float _laserSpeed = 8f;
    [SerializeField] private GameObject _laserPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //translate laser up
        _laserPrefab.transform.Translate(0, 0.5f, 0); 
    }
}
