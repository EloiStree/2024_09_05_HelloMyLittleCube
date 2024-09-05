using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem; 

public class CallbackContextSplitterMono : MonoBehaviour
{
    public UnityEvent m_onClick;
    public UnityEvent m_onRelease;

    public void PushContext(InputAction.CallbackContext context)
    {
       float value = context.action.ReadValue<float>();
        if(value > 0.5)
        {
            m_onClick.Invoke();
        }
        else
        {
            m_onRelease.Invoke();
        }
       
    }
    
}
