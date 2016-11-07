using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class MobileEventTrigger : EventTrigger {

    public Func<int> testFunction;

    public override void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("TEST");
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        testFunction();
    }

}

