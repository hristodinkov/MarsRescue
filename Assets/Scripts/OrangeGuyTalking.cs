using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OrangeGuyTalking : MonoBehaviour
{
    public AudioSource talking;
    private void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            talking.Play();
        }
    }


}
