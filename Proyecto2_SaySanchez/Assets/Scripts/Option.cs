using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Option : MonoBehaviour
{
    //Define el identificador y el texto de las opciones
    public int OptionID;
    public string OptionName;

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<TMP_Text>().text = OptionName;
    }

    //Actualiza el texto de las opciones
    public void UpdateText()
    {
        transform.GetChild(0).GetComponent <TMP_Text>().text = OptionName;
    }
    //Te declara la opcion que el jugador selecciona
    public void SelectOption()
    {
        LevelManager.Instance.SetPlayerAnswer(OptionID);
        LevelManager.Instance.CheckPlayerState();
    }
}
