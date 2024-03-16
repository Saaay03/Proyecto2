using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class LessonContainer : MonoBehaviour
{
    //DEfine el número de lecciones, la leccion actual y si todas las lecciones se realizaron
    [Header ("GameObject Configuration")]
    public int Lection = 0;
    public int CurrentLession = 0;
    public int TotalLessions = 0;
    public bool AreAllLessonsComplete = false;

    //Configura el titulo y el texto que contiene cada leccion
    [Header("UICharInfo Configuration")]
    public TMP_Text StageTitle;
    public TMP_Text LessonStage;

    //Contenedor de las lecciones
    [Header("External GameObject Configuration")]
    public GameObject lessonContainer;

    //Administra las lecciones a través de un scriptable object
    [Header("Lesson Data")]
    public ScriptableObject lessonData;

    // Start is called before the first frame update
    void Start()
    {
      if (lessonContainer !=null) 
        {
            OnUpdateUI();
        }
      else
        {
            Debug.LogWarning("GameObject Nulo, revisa las variables de tipo GameObject lessonContainer " + name);
        }
    }

    //Actualiza las lecciones en la interfaz
    public void OnUpdateUI()
    {
        if (StageTitle != null || LessonStage !=null) 
        {
            StageTitle.text = "Leccion " + Lection;
            LessonStage.text = "Leccion " + CurrentLession + " de " + TotalLessions;
        }
        else
        {
            Debug.LogWarning("GameObject Nulo, revisa las variables de tipo TMP_Text");
        }
    }

    //Este modo activa/desactiva la ventana de lessonContainer
    public void EnableWindow()
    {
        if (lessonContainer.activeSelf)
        {
            //Desactiva el objeto si está activo
            lessonContainer.SetActive(false);
        }
        else
        {
            //Activa el objeto si está desactivado
            lessonContainer.SetActive(true);
        }
    } 
}
