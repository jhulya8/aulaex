using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class Atividade : MonoBehaviour
{
    [SerializeField] string _nome = "player";
    [SerializeField] string _apelido ;
    [SerializeField] string _Sobrenome ;
    // Start is called before the first frame update
    void Start()
    {
        _nome = "lucio" + " " + _Sobrenome + " " +_apelido;
     
      }      

    // declarar 3 classes de texto
    // implementar o valor somente na primeira 
    // alterar a primeira variavel 

    // na funçao start 
    // concatenar na 1 , 2  e 3 váriavel 
    void Update()
    {
        
    }
}
