using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private string nomeLevelJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelConfig;
    public void Jogar()
    {
        SceneManager.LoadScene(nomeLevelJogo);
    }
    public void abrirConfig()
    {
        painelMenuInicial.SetActive(false);
        painelConfig.SetActive(true);
    }
    public void sairConfig()
    {
        painelMenuInicial.SetActive(true);
        painelConfig.SetActive(false);
    }
    public void Sair()
    {
        Application.Quit();
    }
}
