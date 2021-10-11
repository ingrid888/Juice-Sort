using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bia : MonoBehaviour
{
    [SerializeField] private Image botao;
    [SerializeField] private Sprite[] botoes;
    private bool _botaoLigado;

    public void LigarOpcao()
    {
        switch (_botaoLigado)
        {
            case true:
                botao.sprite = botoes[0];
                _botaoLigado = false;
                break;

            case false:
                botao.sprite = botoes[1];
                _botaoLigado = true;
                break;
        }
    }
}
