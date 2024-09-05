using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectMono : MonoBehaviour
{

    public Space m_spaceToRotate = Space.World;
    public Vector3 m_rotate = Vector3.up;
    public float m_speed = 1.0f;
    void Start()
    {
        Debug.Log("Hello World");
    }

    void Update()
    {
        transform.Rotate(m_rotate * Time.deltaTime* m_speed, m_spaceToRotate);
    }
}
