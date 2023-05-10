using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlamenu : MonoBehaviour
{
    [SerializeField] GameObject panel_inicial;
    [SerializeField] GameObject panel_carregar;
    [SerializeField] GameObject panel_personagem;
    // Start is called before the first frame update
    public void Ativarpainel_iniciar()
    {
        panel_inicial.SetActive(true);
        panel_carregar.SetActive(false);
        panel_personagem.SetActive(false);
    }
    public void Ativarpanel_carregar()
    {
        panel_inicial.SetActive(false);
        panel_carregar.SetActive(true);
        panel_personagem.SetActive(false);
    }
    public void Ativarpanel_personagem()
    {
        panel_inicial.SetActive(false);
        panel_personagem.SetActive(true);
        panel_carregar.SetActive(false);
    }
 }

   
    /*
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
   */