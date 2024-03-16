using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Leccion
{
    //Representa el identificador de las lecciones
    public int ID;
    public string lessons;
    //Declara las opciones disponibles para la leccion
    public List<string> options;
    //Indica la respuesta correcta
    public int correctAnswer;
}
