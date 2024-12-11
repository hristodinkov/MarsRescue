using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oxygentank : MonoBehaviour
{
    public Inventory p_inventory;
    public AirCanister o2Tank;

    // Update is called once per frame
    void Update()
    {
        if (p_inventory.HasItem("Oxygentank"))
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log("Georgi ima kislorod :)");
                o2Tank.O2TankRefill();
                p_inventory.RemoveItem("Oxygentank");
            }
        }
    }
}
