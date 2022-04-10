using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        LeanTween.move(GetComponent<RectTransform>(), new Vector3(0f, 134f, 0f), .3f).setDelay(.3f).setEase(LeanTweenType.easeOutCubic).setIgnoreTimeScale(true);
        Time.timeScale = 0f;



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
