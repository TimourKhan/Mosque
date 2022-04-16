using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public GameObject blackScreen;
    // Start is called before the first frame update
    void Start()
    {
        blackScreen.SetActive(true);
        LeanTween.alpha(blackScreen.GetComponent<RectTransform>(), 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
