using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiopanel : MonoBehaviour
{
    [SerializeField]public GameObject canvas1;
    [SerializeField]public GameObject canvas2;
    // Start is called before the first frame update
    
    public void changecanvas()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(true);
    }
}
