using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    [SerializeField] private float _playerSpeed = 80;
    //public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //transform.Translate(Vector3.right * horizontalInput * _playerSpeed * Time.deltaTime);
        //transform.Translate(Vector3.up * verticalInput * _playerSpeed * Time.deltaTime);

        //transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * _playerSpeed * Time.deltaTime);
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * _playerSpeed * Time.deltaTime);

    }
}
