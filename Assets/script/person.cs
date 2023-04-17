using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class person: MonoBehaviour
{
    [SerializeField] string _nome = "mario";
    [SerializeField] int _idade;
    [SerializeField] float _velocidade;
    [SerializeField] GameObject _Personagem;
    
    
    [SerializeField] Transform _Poss;
    [SerializeField] Vector2 _pos;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
