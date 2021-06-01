using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private float _laserSpeed = 0.08f;
    [SerializeField] private GameObject _laserPrefab;

    // Update is called once per frame
    void Update()
    {
        _laserPrefab.transform.Translate(0, _laserSpeed, 0);

        if (transform.position.y >= 10)
        {
            Destroy(gameObject);
        }
    }
}
