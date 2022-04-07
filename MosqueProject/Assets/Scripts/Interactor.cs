using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TouchControlsKit;

public class Interactor : MonoBehaviour
{
    public LayerMask interactableLayermask = 7;
    UnityEvent onInteract;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward, out hit, 4, interactableLayermask))
        {
            if(hit.collider.GetComponent<Interactable>() != false)
            {
                onInteract = hit.collider.GetComponent<Interactable>().onInteract;
                
                if(Input.GetKeyDown(KeyCode.E))
                {
                    onInteract.Invoke();
                }

                if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    onInteract.Invoke();
                }
            }
        }
    }
}
