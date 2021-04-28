using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform prefab;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(i * 0.0f, 0, 0), Quaternion.identity);
        }
    }
}
