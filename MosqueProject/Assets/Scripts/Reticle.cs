using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Reticle : MonoBehaviour
{
    [SerializeField] private Image reticle;
    [SerializeField] private TMP_Text text;


    private void Start()
    {
        reticle.color = new Color(1, 1, 1, 0.5f);
    }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 3f))
        {
            if (hit.transform.gameObject.CompareTag("Object"))
            {
                reticle.color = new Color(0.5f, 1, 0.5f, 1f);
                text.enabled = true;
            }
            else
            {
                reticle.color = new Color(1, 1, 1, 0.5f);
                text.enabled = false;
            }
        }
        else
        {
            reticle.color = new Color(1, 1, 1, 0.5f);
            text.enabled = false;
        }
    }
}