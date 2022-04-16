using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UITween : MonoBehaviour
{
    [SerializeField] GameObject dialog;
    [SerializeField] GameObject blocker;

    void OnEnable()
    {
        dialog.GetComponent<CanvasGroup>().alpha = 0;
        transform.localScale = new Vector3(1, 1, 1);
        
    }

    public void Open()
    {
        blocker.SetActive(true);
        dialog.SetActive(true);
        LeanTween.scale(dialog, new Vector3(1.3f, 1.3f, 1.3f), .75f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.alphaCanvas(dialog.GetComponent<CanvasGroup>(), 1f, .75f).setEase(LeanTweenType.easeOutCubic);



    }

    public void CloseInitialize()
    {
        LeanTween.scale(dialog, new Vector3(1f, 1f, 1f), .75f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.alphaCanvas(dialog.GetComponent<CanvasGroup>(), 0f, .75f).setEase(LeanTweenType.easeOutCubic);
        Invoke("Close", .75f);

    }

    void Close()
    {
        dialog.SetActive(false);
        blocker.SetActive(false);
    }

  
}
