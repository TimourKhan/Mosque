using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDialog : MonoBehaviour

{
    [SerializeField] GameObject dialog;
    [SerializeField] GameObject dimmer;
    // Start is called before the first frame update
    void Start()
    {
        dimmer.SetActive(true);
        dialog.GetComponent<CanvasGroup>().alpha = 0;
        transform.localScale = new Vector3(1, 1, 1);
        Invoke("Open", .1f);
    }

    public void Open()
    {
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
        dimmer.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
