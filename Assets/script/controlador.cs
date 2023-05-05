using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador : MonoBehaviour
{
    [SerializeField] GameObject _shepere;
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _cylinder;
    [SerializeField] GameObject _capsule;
    [SerializeField] bool _checkcube;
    // Start is called before the first frame update
    void Start()
    {
     // se _checkcube foir verdadeiro
        _cube.SetActive(false);

        //_cube
        if (_checkcube == false)

        {
         _cube.SetActive(false);
        }
        else
        {
         _cube.SetActive(true);
        }

        // _shepere
        if (_checkcube == false)

        {
           _shepere.SetActive(false);
        }
        else
        {
            _shepere.SetActive(true);
        }

        //_cylinder
        if (_checkcube == false)

        {
            _cylinder.SetActive(false);
        }
        else
        {
            _cylinder.SetActive(true);
        }
        // _capsule
        if (_checkcube == false)

        {
           _capsule.SetActive(false);
        }
        else
        {
          _capsule.SetActive(true);
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
