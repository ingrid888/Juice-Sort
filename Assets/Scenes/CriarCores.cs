using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using corcor;

public class CriarCores : MonoBehaviour
{
   
    public Stack<Color> stack;

    [SerializeField] private Image[] imagens;
        
    private void Start()
    {
        stack = new Stack<Color>();
        Imagem();
       
    }

    private void Imagem()
    {
        foreach (var imagem in imagens)
        {
            int index = Random.Range(0, InformacoesGerais.cores.Count);
            Color cor = InformacoesGerais.cores[index];
            imagem.color = cor;
            InformacoesGerais.coresUsadas[index]++;
            if (InformacoesGerais.coresUsadas[index] == 4)
            {
                InformacoesGerais.cores.RemoveAt(index);
            }
        }
    }
}



