using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.alpha(GetComponent<RectTransform>(), 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}