using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UITween : MonoBehaviour
{
    [SerializeField] GameObject minbar;
    void OnEnable()
    {
        LeanTween.scale(minbar, new Vector3(1.3f, 1.3f, 1.3f), .75f).setEase(LeanTweenType.easeOutCubic);
        
        

    }

    void OnDisable()
    {
        LeanTween.scale(minbar, new Vector3(.1f, .1f, .1f), .25f);
        
    }

  
}
