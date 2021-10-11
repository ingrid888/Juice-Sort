using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using corcor;

public class CriarCores : MonoBehaviour
{
    [SerializeField] private float distancia;
    [SerializeField] private float timer;
    private Cena cena;
    private bool estaSelecionado;
    public Stack<Color> stack;
    public bool Pintar { get; set; }
    public int Index { get; set; }

    [SerializeField] private Image[] imagens;

    private void Awake()
    {
        cena = FindObjectOfType<Cena>();
    }
    private void Start()
    {
        stack = new Stack<Color>();
        Imagem();
    }

    private void Imagem()
    {
        foreach (var imagem in imagens)
        {
            
            Color cor ;
            if (Pintar)
            {
                int index = Random.Range(0, InformacoesGerais.cores.Count);
                cor = InformacoesGerais.cores[index];
                InformacoesGerais.coresUsadas[index]++;
                if (InformacoesGerais.coresUsadas[index] == 4)
                {
                    InformacoesGerais.cores.RemoveAt(index);
                }
            }
            else
            {
                cor = new Color(0, 0, 0, 0);
            }
            
            imagem.color = cor;
        }
    }
    public void StartMover()
    {
        StartCoroutine(Mover());
    }
   
    private IEnumerator Mover()
    {
        switch (estaSelecionado)
        {
            case false:
                if (cena.IndexSelecionado == Index)
                {
                    for (int i = 0; i < distancia; i++)
                    { 
                        transform.position += Vector3.up;
                        yield return new WaitForSeconds(timer);
                    }

                    cena.IndexSelecionado = Index;
                    cena.ObjetoSelecionado = gameObject;  
                    estaSelecionado = cena.EstaSelecionda = true;
                }
                else
                {
                    if (cena.ObjetoSelecionado.transform.position.x > transform.position.x)
                    {
                        for (var i = transform.position.x; i < cena.ObjetoSelecionado.transform.position.x - 100; i++)
                        {
                           cena.ObjetoSelecionado.transform.position += Vector3.left;  
                        }
                    }
                    else
                    {
                        for (var i = cena.ObjetoSelecionado.transform.position.x; i < transform.position.x - 100; i++)
                        {
                            cena.ObjetoSelecionado.transform.position += Vector3.right;  
                        }
                    }
                }
                break;
         
            case true:
                for (int i = 0; i < distancia; i++)
                { 
                    transform.position -= Vector3.up;
                    yield return new WaitForSeconds(timer);
                }
                estaSelecionado = cena.EstaSelecionda = false;
                break;
        }

        
    }
}



