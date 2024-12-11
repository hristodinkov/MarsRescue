using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatchAnimations : MonoBehaviour
{
    public bool isDoorOpenedToMars = false;
    public Animator innerDoorMars;
    public Animator innerDoorMars1;

    public Animator innerDoorStation;
    public Animator innerDoorStation1;

    public AudioClip vaccum;
    public AudioSource audio;
    public AudioClip air;

    public ParticleSystem particle;
    public ParticleSystem particle1;

    public bool airRefil = true;
    
    private void OnTriggerEnter(Collider other)
    {
        
        //Debug.Log("The trigger was hit");
        if (!isDoorOpenedToMars)
        {      
            innerDoorStation.gameObject.SetActive(true);
            innerDoorStation1.gameObject.SetActive(true);
            innerDoorStation.SetBool("DoorOpen", false);
            innerDoorStation1.SetBool("DoorOpen", false);
            audio.clip = vaccum;
            audio.Play();
            
        }
        else if (isDoorOpenedToMars)
        {
            innerDoorMars.gameObject.SetActive(true);
            innerDoorMars1.gameObject.SetActive(true);
            innerDoorMars.SetBool("DoorOpen", false);
            innerDoorMars1.SetBool("DoorOpen", false);
            audio.clip = air;
            audio.Play();
            airRefil = true;
        }
        StartCoroutine(WaitForSound());
    }
    IEnumerator WaitForSound()
    {
        
        while (audio.isPlaying)
        {
            if (isDoorOpenedToMars)
            {
                particle.Play();
                particle1.Play();
            }
            yield return null;
        }
        if (isDoorOpenedToMars)
        {
            
            particle.Stop();
            particle1.Stop();
            GoInside();
        }
        else
        {
            GoToMars();
        }
    }
    public void GoToMars()
    {
        innerDoorMars.SetBool("DoorOpen", true);
        innerDoorMars1.SetBool("DoorOpen", true);
        airRefil = false;
        

        isDoorOpenedToMars = true;
    }
    public void GoInside()
    {
        innerDoorStation.SetBool("DoorOpen", true);
        innerDoorStation1.SetBool("DoorOpen", true);
        isDoorOpenedToMars = false;



    }
}
