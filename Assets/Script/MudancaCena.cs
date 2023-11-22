using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudancaCena : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject telaInicial, telaOpcoes, telaCreditos, telaLobby;
    public string cenaJOGO;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScene()
    {

      SceneManager.LoadScene(cenaJOGO);


    }

    public void ShowInicial()
    {        
        telaLobby.SetActive(false);
        telaCreditos.SetActive(false);
        telaOpcoes.SetActive(false);
        telaInicial.SetActive(true);
    }

    public void ShowOpcoes()
    {
        telaLobby.SetActive(false);
        telaCreditos.SetActive(false);
        telaInicial.SetActive(false);
        telaOpcoes.SetActive(true);
    }

    public void ShowLobby()
    {        
        telaCreditos.SetActive(false);
        telaOpcoes.SetActive(false);
        telaInicial.SetActive(false);
        telaLobby.SetActive(true);
    }
    public void ShowCreditos()
    {
        telaLobby.SetActive(false);        
        telaOpcoes.SetActive(false);
        telaInicial.SetActive(false);
        telaCreditos.SetActive(true);
    }

    public void Sair()
    {
        Application.Quit();
    }
}
