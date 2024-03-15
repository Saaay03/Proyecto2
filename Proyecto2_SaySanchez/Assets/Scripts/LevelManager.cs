using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    [Header("Level Data")]
    public Subject Lesson;

    [Header("User Interface")]
    public TMP_Text QuestionTxt;
    public List<Option> Options;

    [Header("GameConfiguration")]
    public int questionAmount = 0;
    public int currentQuestion = 0;
    public string question;
    public string correctAnswer;
    public string anwerFromPlayer;

    [Header("Current Lesson")]
    public Leccion currentLesson;
    
    private void Awake()
    {
        if (Instance != null)
        {
            return;
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Establecemos la cantidad de preguntas en la lección
        questionAmount = Lesson.leccionList.Count;
        //Cargar la primer pregunta
        LoadQuestion();
    }
    private void LoadQuestion()
    {
        //Aseguramos que la pregunta actual este dentro de los limites
        if (currentQuestion < questionAmount) 
        {
            //Establecemos la leccion actual
            currentLesson = Lesson.leccionList[currentQuestion];
            //Establecemos la pregunta
            question = currentLesson.lessons;
            //Establecemos la respuesta correcta
            correctAnswer = currentLesson.options[currentLesson.correctAnswer];
            //Establecemos la pregunta en UI
            QuestionTxt.text = question;
        //Establecemos las opciones
        //Options[0].transform.GetChild(0).GetComponent<TMP_Text>().text = currentLesson.options[0];
            foreach (string option in currentLesson.options)
            {
                foreach (Option opt in Options)
                {
                    opt.OptionName = option;
                }
            }
        }
        else
        {
            //Si llegamos al final de las preguntas
            Debug.Log("Fin de las preguntas");
        }
    }
    public void NextQuestion()
    {
        if (currentQuestion < questionAmount)
        { 
        //Incrementamos el indice de la pregunta actual
        currentQuestion++;
        //Cargar la nueva pregunta
        LoadQuestion();
        }
        else
        {
            //Cambio de escena
        }
    }

    public void Set
}
