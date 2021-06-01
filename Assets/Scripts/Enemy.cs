using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _enemySpeed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move down at 4 meters per second
        transform.Translate(Vector3.down * _enemySpeed * Time.deltaTime);

        //if at bottom of screen
        //respawn at top with a new random x position

        if (transform.position.y < -8f)
        {
            transform.position = new Vector3(0, 8, 0);
        }
        
    }
}
