using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Subject", menuName = "ScriptableObjects/New_Lesson", order = 1)]
//Define una clase que se hereda de un scriptable object
public class Subject : ScriptableObject
{
    [Header("GameObject Configuration")]
    //Representa el numero de leccion
    public int Lesson = 0;

    [Header("Lession Quest Configuration")]
    //Declara la lista de lecciones
    public List<Leccion> leccionList;
}