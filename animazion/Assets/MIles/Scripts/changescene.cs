using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{

//pj1
     [SerializeField]public GameObject gwen1;
    [SerializeField] public GameObject pavo1;
  //pj2
    [SerializeField] public GameObject gwen2;
    [SerializeField] public GameObject miles2;
    public string gwenvgwen, gwenvmiles, pavovgwen, pavovmiles;
    


    //[SerializeField]public string escena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cambio()
    {
        if (gwen1.activeSelf&& gwen2.activeSelf)
        {
            SceneManager.LoadScene(gwenvgwen);
        }
        else if (gwen1.activeSelf&& miles2.activeSelf)
        {
            SceneManager.LoadScene(gwenvmiles);
        }
        else if (pavo1.activeSelf && gwen2.activeSelf)
        {
            SceneManager.LoadScene(pavovgwen);
        }
        else if (pavo1.activeSelf && miles2.activeSelf)
        {
            SceneManager.LoadScene(pavovmiles);
        }
        else
        {
            return;
        }  
    }
}
