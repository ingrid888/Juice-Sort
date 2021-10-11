using System.Collections;
using System.Collections.Generic;
using corcor;
using UnityEngine;
using UnityEngine.UI;

public class CriarCopos : MonoBehaviour
{
    [SerializeField] private CriarCores copo;
    [SerializeField] private HorizontalLayoutGroup tela;

    private void Start()
    {
        for (int i = 0; i < InformacoesGerais.numeroDeCopos; i++)
        {
            Criar(i < InformacoesGerais.numeroDeCopos -1, i);
        }
    }
    private void Criar(bool b, int i)
    {
        var instanciaCopo =  Instantiate(copo, tela.transform);
        instanciaCopo.Pintar = b;
        instanciaCopo.Index = i;
    }
}
