using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public GameManeger gameManeger;
  

    void OnTriggerEnter()
    {
       gameManeger.ComepliteLevel();
    }
}
