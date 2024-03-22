using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class SubjectContainer : MonoBehaviour
{
    [Header("GameObject Configuration")]
    [SerializeField]
    public int Lesson = 0;

    [Header("Lession Quest Configuration")]
    [SerializeField]
    public List<Leccion> LeccionList;
}
