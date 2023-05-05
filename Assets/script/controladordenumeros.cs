using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladordenumeros : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _shepere;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cylinder;

    [SerializeField] int _numero;
    // Start is called before the first frame update
    void Start()
    {

        // se o numero for 1, ativar o gameobject cube
        // se o numero for 2, ativar o gameobject sphere
        // se o numero for 3, ativar o gameobject capsule
        // se o numero for 4, ativar o gameobject cylinder
        // se o numero for menor que 1, desativar todos os gameobjects
        // se o numero for maior que 4, ativar todos os gameobjects
        // Update is called once per frame
    }
    void Update()
    {
        { 

            if (_numero == 1)
            {
                _cube.SetActive(true);
            }
            else
            {
                _cube.SetActive(false);

            }
            if (_numero == 2)
            {
                _shepere.SetActive(true);
            }
            else
            {
                _shepere.SetActive(false);
            }
            if (_numero == 3)
            {
                _capsule.SetActive(true);
            }
            else
            {
                _capsule.SetActive(false);
            }
            if (_numero == 4)
            {
                _cylinder.SetActive(true);
            }
            else
            {
                _cylinder.SetActive(false);
            }
            if (_numero < 1)
            {
             _cube.SetActive(false);
             _shepere.SetActive(false);
             _capsule.SetActive(false);
             _cylinder.SetActive(false);
            }
           else if (_numero > 5)
            {
             _cube.SetActive(true);
             _shepere.SetActive(true);
             _capsule.SetActive(true);
             _cylinder.SetActive(true);
            
           }
        }
    }

    
}
