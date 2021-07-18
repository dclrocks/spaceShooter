using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    [SerializeField] private float _playerSpeed = 20f;
    [SerializeField] private GameObject _laserPrefab;
    [SerializeField] private float _offset = 1f;
    [SerializeField] private float _fireRate = 0.1f;
    [SerializeField] private float _canFire = -0.5f;
    [SerializeField] private int _lives = 3;
    [SerializeField] private GameObject _playerPrefab;
    private SpawnManager _spawnManager;

    [SerializeField] private bool _tripleShotActive = false;
    [SerializeField] private GameObject _tripleShotPrefab;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        _spawnManager = GameObject.Find("Spawn_Manager").GetComponent<SpawnManager>();

        if(_spawnManager == null)
        {
            Debug.LogError("The SpawnManager is NULL.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        CalculatePlayerMovement();
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _canFire)
        {
            FireLaser();
        }
    }

    void CalculatePlayerMovement()
    {
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");

    Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
    transform.Translate(direction* _playerSpeed * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3, 0), 0);

        if (transform.position.x >= 11.2f)
        {
            transform.position = new Vector3(-11.2f, transform.position.y, 0);
        }
        else if (transform.position.x <= -11.2f)
        {
            transform.position = new Vector3(11.2f, transform.position.y, 0);
        }
    }

    void FireLaser()
    {
        _canFire = Time.time + _fireRate;

        if (_tripleShotActive == true)
        {
            Instantiate(_tripleShotPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(_laserPrefab, transform.position + new Vector3(0, 1.05f, 0), Quaternion.identity);
        }
    }

    public void Damage()
    {
        _lives--;

        if (_lives < 1)
        {
            Destroy(this._playerPrefab);
            _spawnManager.OnPlayerDeath();
        }
    }
}