using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tenoverfive : MonoBehaviour
{
    public GameObject prefab;
    Vector3 myVector;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            myVector = new Vector3((5.0f*i), 0.0f, 0.0f);
            GameObject go = Instantiate(prefab, myVector, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
