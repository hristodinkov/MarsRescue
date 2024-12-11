using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using UnityEngine;
using UnityEngine.UI;

public class AirCanister : MonoBehaviour
{
    public Slider air;
    public float maxSecondsOfO2;
    private float timeStart;
    private float elapsed = 0f;
    [SerializeField] float oxygenLeftNsec = default;
    [SerializeField] float oxygenRefilNsec = default;
    public HatchAnimations pressurePlate;
    public HatchAnimations pressurePlate1;
    public Image fadeToBlack;
    public float fadeDuration;
    public GameObject LoseScreen;
    public ThirdPersonController playerController;

    public GameObject BlurVolume;
    private void Start()
    {
        timeStart = maxSecondsOfO2;
        SetMaxO2(timeStart);
    }

    // Update is called once per frame
    void Update()
    {
          fadeToBlack.color = new Color(fadeToBlack.color.r, fadeToBlack.color.g, fadeToBlack.color.b, 0);
          if (pressurePlate.airRefil || pressurePlate1.airRefil)
          {
              O2Refilling();
              
          }
          else 
          {  
              O2Depleting();
          }
       // O2Depleting();
    }
    public void SetMaxO2(float maxO2)
    {
        air.maxValue = maxO2;
    }
    public void O2TankRefill()
    {
        //air.value = air.maxValue;
        timeStart += maxSecondsOfO2/2f;
        if (timeStart > maxSecondsOfO2)
        {
            timeStart = maxSecondsOfO2;
        }
       
        Color color = fadeToBlack.color; // Get current color
        color.a = 0;
        fadeDuration = 0;
        BlurVolume.SetActive(false);
    }

    [ContextMenu("Refill")]
    private void O2Refilling()
    {
        if (timeStart < air.maxValue)
        {
            air.value = timeStart += Time.deltaTime * oxygenRefilNsec;
            //timeStart = maxSecondsOfO2;
        }
        air.fillRect.gameObject.SetActive(true);
        Color color = fadeToBlack.color; // Get current color
        BlurVolume.SetActive(false);
        color.a =0;
        fadeDuration = 0;

    }
    private void O2Depleting()
    {
        if (timeStart > 0)
        {
            air.value = timeStart -= Time.deltaTime * oxygenLeftNsec;
        }
        if (timeStart < 20)
        {
            BlurVolume.SetActive(true);
        }
        if (timeStart < 15)
        {
            Color color = fadeToBlack.color; // Get current color
            fadeDuration += Time.deltaTime/10;
            color.a += fadeDuration;
            fadeToBlack.color = color; // Assign updated color back
           // Debug.Log($"Updated alpha: {color.a}");
        }
        if(fadeToBlack.color.a > 1.1f)
        {
            LoseScreen.gameObject.SetActive(true);
            playerController.gameObject.SetActive(false);
        }
    }
}
