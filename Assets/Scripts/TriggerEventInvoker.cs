using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventInvoker : MonoBehaviour
{
    // UnityEvent that is invoked when another collider enters the trigger.
    public UnityEvent onTriggerEnterEvent;

    // UnityEvent that is invoked when another collider stays on the trigger.
    public UnityEvent onTriggerStayEvent;

    // UnityEvent that is invoked when another collider exits the trigger.
    public UnityEvent onTriggerExitEvent;

    void OnTriggerEnter(Collider other)
    {
        // Checks if the script is enabled to perform detection, otherwise exit
        if (!enabled) return;

        //Some more advanced features you can enable if you need a layer or tag filter.
        //if ((layerMask.value & (1 << other.gameObject.layer)) == 0) return;
        //if (!string.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;

        // Invoke the onTriggerEnterEvent when a collider enters the trigger.
        onTriggerEnterEvent?.Invoke();
    }

    // This method is called when another collider stays on the trigger collider
    // attached to the GameObject to which this script is attached.
    // 'other' represents the Collider that stays on the trigger.
    void OnTriggerStay(Collider other)
    {
        // Checks if the script is enabled to perform detection, otherwise exit
        if (!enabled) return;

        //Some more advanced features you can enable if you need a layer or tag filter.
        //if ((layerMask.value & (1 << other.gameObject.layer)) == 0) return;
        //if (!string.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;

        // Invoke the onTriggerEnterEvent when a collider enters the trigger.
        onTriggerStayEvent?.Invoke();
    }

    // This method is called when another collider exits the trigger collider
    // attached to the GameObject to which this script is attached.
    // 'other' represents the Collider that exits the trigger.
    void OnTriggerExit(Collider other)
    {
        // Checks if the script is enabled to perform detection, otherwise exit
        if (!enabled) return;

        //Some more advanced features you can enable if you need a layer or tag filter.
        //if ((layerMask.value & (1 << other.gameObject.layer)) == 0) return;
        //if (!string.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;

        // Invoke the onTriggerExitEvent when a collider exits the trigger.
        onTriggerExitEvent?.Invoke();
    }
}
