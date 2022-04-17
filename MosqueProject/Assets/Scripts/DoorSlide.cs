using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlide : MonoBehaviour
{
    public AudioSource audioSourceOne;
    public AudioSource audioSourceTwo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoorSlideOpen()
    {
        audioSourceOne.Play();
    }

    public void DoorSlideClose()
    {
        audioSourceTwo.Play();
    }
}
