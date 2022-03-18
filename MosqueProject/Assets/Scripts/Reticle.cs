using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reticle : MonoBehaviour
{
    [SerializeField] private Image reticle;

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
            }
            else
            {
                reticle.color = new Color(1, 1, 1, 0.5f);
            }
        }
        else
        {
            reticle.color = new Color(1, 1, 1, 0.5f);
        }
    }
}