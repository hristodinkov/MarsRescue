using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPlayer : MonoBehaviour
{
    public float delay = 0.1f;
    public GameObject playerToDisplay;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Display", delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Display()
    {
        playerToDisplay.SetActive(true);
    }
}
