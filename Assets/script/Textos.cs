using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textos : MonoBehaviour
{
    [SerializeReference] string _nome= "";
    [SerializeReference] string _Sobrenome;
    [SerializeReference] string _Nomecompleto ;
    [SerializeField] Text _texto;

    // Start is called before the first frame update

    void Start()
    {
        _nome = "jorge";
        _Nomecompleto = _nome +" " + "dos" + " "+ _Sobrenome;
        _texto.text = _Nomecompleto;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
