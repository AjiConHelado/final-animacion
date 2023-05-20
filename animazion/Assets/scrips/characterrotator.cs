using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterrotator : MonoBehaviour
{
    [SerializeField]public  GameObject[] pjs = new GameObject[3];
    // Start is called before the first frame update
  public void changepj()
    {
        foreach(GameObject pj in pjs)
            { pj.SetActive(!pj.activeInHierarchy); }
        
    }
}
