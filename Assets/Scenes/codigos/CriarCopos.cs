using System.Collections;
using System.Collections.Generic;
using corcor;
using UnityEngine;
using UnityEngine.UI;

public class CriarCopos : MonoBehaviour
{
    [SerializeField] private GameObject copo;
    [SerializeField] private HorizontalLayoutGroup tela;

    private void Start()
    {
        for (int i = 0; i < InformacoesGerais.numeroDeCopos; i++)
        {
            Criar();
        }
    }
    private void Criar()
    {
        Instantiate(copo, tela.transform);
    }
}
