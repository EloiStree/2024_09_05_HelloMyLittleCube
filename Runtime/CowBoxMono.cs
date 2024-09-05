using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CowBoxMono : MonoBehaviour
{

    public UnityEvent m_onMouseClick;

    public AudioSource m_audioSource;

    public void OnMouseDown()
    {
        
        Debug.Log("CowBoxMono.OnMouseDown");
        m_audioSource.Play();

        m_onMouseClick.Invoke();
    }

    public void PlaySound()
    {
        m_audioSource.Play();
    }
    

}
