using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _enemySpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime);

        //if bottom of screen
        //respawn at top with a new random x position

        if (transform.position.y < -8f)
        {
            float randomX = Random.Range(-8f, 8f);
            transform.position = new Vector3(randomX, 7, 0);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if other is player
        //destroy Enemy
        //damage player
        //if other is laser
        //destroy laser
        //destroy enemy

        Debug.Log("Hit: " + other.transform.name);
    }
}
