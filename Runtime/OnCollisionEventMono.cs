using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionEventMono : MonoBehaviour
{

    public LayerMask m_canCollideBy;
    public UnityEvent m_onCollision;


    public GameObject m_lastHitObject;

    public void OnCollisionEnter(Collision collision)
    {
        m_lastHitObject = collision.gameObject;

        if (IsInLayerMask(collision.gameObject, m_canCollideBy))
        {
            m_onCollision.Invoke();
        }

    }

    public static bool IsInLayerMask(GameObject obj, LayerMask mask) => (mask.value & (1 << obj.layer)) != 0;
    public static bool IsInLayerMask(int layer, LayerMask mask) => (mask.value & (1 << layer)) != 0;
}
