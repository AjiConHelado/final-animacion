using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnar : MonoBehaviour
{
    [SerializeField]public string nombre;


    public void change()
    {
        SceneManager.LoadScene(nombre);
    }
}