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

    //private void OnTriggerEnter(Collider other)
    //{
        //if other is enemy
        //destroy laser
        //destroy enemy

        //Debug.Log("Hit: " + other.transform.name);
    //}

    private void Collision(OnCollision collision)

    {
        List<Collider> colliders = new List<Collider>();

        if (collision.collider.gameObject.tag = "Enemy")
        {
            colliders.Add(collision.collider); // saves the enemy for later respawn
            collision.collider.gameObject.active = false; // deactivate instead of destroy so you could later reactivate (respawn) him
        }
    }
}
