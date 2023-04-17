using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform _pos;
    [SerializeField] Vector3 _pos2;

    void Start()
    {
        _pos.localScale = new Vector3(10, 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
