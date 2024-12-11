using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimationHelper : MonoBehaviour
{
    public void DissableDoor()
    {
        gameObject.SetActive(false);
    }

    public void EnableDoor()
    {
        gameObject.SetActive(true);
    }
}
