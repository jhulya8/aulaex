using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicoes : MonoBehaviour
{
    [SerializeField] int _i1, _i2;
    [SerializeField] string _t1, t2;
    [SerializeField] float _f1, _f2;
    [SerializeField] bool _b1, _b2;
    [SerializeField] 
    // Start is called before the first frame update
    void Start()
    {
        // > Maior
        // < Menor
        // <= Menor ou igual
        // >= Maior ou igual
        // != Diferente
        // == igual 
        // && e
        // || ou
        _i1 = 1;
        _i1 = _i2;

        if (_i1 == 1)
        {
           // Debug.Log("fase 1 liberada");
        }
        else
        {
            //Debug.Log("fase 1 bloqueada");

        }


        if (_t1 == "Multiplicação")
        {
            //Debug.Log(_i1 * _i2);

        }
        else
        {
            //Debug.Log(_i1 + _i2);
        }


        // se t1 for igual a multiplicação 
        //multiplixar i1 com a i2 
        // se nao somar i1 com i2 

        //Se a _i1 for igual a 2
        //a _t1 escreve passagem liberada
        //se não _t1, passagem bloqueada
         
        if(_i1 == 2)
        {
            //Debug.Log(_t1 == "passagem liberada");
        }
        else
        {
            //Debug.Log(_t1 == "passagem bloqueada");

        }

        if (_i1 == _i2 && _b1 == true)
        {
            //Debug.Log("entra na fase");
        }

        {
            
            




        }

    }
}