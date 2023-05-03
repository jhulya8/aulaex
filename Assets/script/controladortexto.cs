using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladortexto : MonoBehaviour
{
    [SerializeField] GameObject _shepere;
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _cylinder;
    [SerializeField] GameObject _capsule;
    [SerializeField] string _texto;
    
    // Start is called before the first frame update
    void Start()
    {
      //se o texto for"cube",ativar o gameobject cube
      //se nao desativar
    }

    // Update is called once per frame
    void Update()
    {
        //_cube
        if (_texto == "_cube")
        {
            _cube.SetActive(true);
        }
        else
        {
            _cube.SetActive(false);

        }
        //_shepere
        if (_texto == "_shepere")
        {
            _shepere.SetActive(true);
        }
        else
        {
            _shepere.SetActive(false);
        }
        //_cylinder
        if (_texto == "_cylinder")
        {
            _cylinder.SetActive(true);
        }
        else
        {
            _cylinder.SetActive(false);
      
        }
        //_capsule
        if (_texto == "_capsule")
        {
            _capsule.SetActive(true);
        }
        else
        {
            _capsule.SetActive(false);

        }
    }
    
}
