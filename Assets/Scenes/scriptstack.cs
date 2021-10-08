using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptstack : MonoBehaviour
{
    private Color[] cores = new[] {new Color(0, 255, 255), new Color(255, 0 , 0)};
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
            Color cor = cores[Random.Range(0, cores.Length)];
            imagem.color = cor;
        }
    }
}



