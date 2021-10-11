using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botao : MonoBehaviour
{
    public bool mutado = false;
    [SerializeField] Image toggleOnandmusic;
    [SerializeField] private Image toggleOffandmusic;

    public void Start()
    {
        if (!PlayerPrefs.HasKey("mutado"))
        {
            PlayerPrefs.SetInt("mutado", 0);
            Load(); 
        }
        else
        {
            Load();
        }

        UpdateBotao();
        AudioListener.pause = mutado;
        
    }
    
    
    public void OnOff()
    {
        if (mutado == false)
        {
            mutado = true;
            AudioListener.pause = true;
        }
        else
        {
            mutado = false;
            AudioListener.pause = false;

        }
        Save();
        UpdateBotao();
    }

    public void UpdateBotao()
    {
        if (mutado == false)
        {
            toggleOnandmusic.enabled = true;
            toggleOffandmusic.enabled = false;
        }
        else
        {
            toggleOnandmusic.enabled = false;
            toggleOffandmusic.enabled = true;
        }
    }
    private void Load()
    {
        mutado = PlayerPrefs.GetInt("mutado") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("mutado", mutado ? 1:0);
    }
}
