using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    //speed variable of 8
    [SerializeField] private float _laserSpeed = 2f;
    [SerializeField] private GameObject _laserPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //translate laser up
        _laserPrefab.transform.Translate(0, _laserSpeed, 0);

        //if (GameObject.y = 8)
        //{
        //    Destroy GameObject);
        //}
    }
}
