using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _enemySpeed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * (_enemySpeed * 2) * Time.deltaTime);

        if (transform.position.y < -8f)
        {
            transform.position = new Vector3(Random.Range(-8f, 8f), 7, 0);
        }
        
    }
}
