using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomJumpMono : MonoBehaviour
{

    public Transform m_whatToRotate;
    public Rigidbody m_toAffectRigidBody;

    public float m_jumpForceToApply = 10.0f;
    public ForceMode m_forceMode = ForceMode.Impulse;

    public Vector3 m_directionWorld = Vector3.up;

    public float m_torqueForceMin = 5;
    public float m_torqueForceMax = 30;
    public ForceMode m_rotateForceMode = ForceMode.Impulse;


    [ContextMenu("Jump")]
    public void Jump()
    {
        m_toAffectRigidBody.AddForce(m_directionWorld * m_jumpForceToApply, m_forceMode);
        m_toAffectRigidBody.AddTorque(
            Random.Range(m_torqueForceMin, m_torqueForceMax),
            Random.Range(m_torqueForceMin, m_torqueForceMax), 
            Random.Range(m_torqueForceMin, m_torqueForceMax),
            m_forceMode);

        //Un Vieux code.
        //m_whatToRotate.Rotate(Vector3.right, Random.Range(m_torqueForceMin, m_torqueForceMax), Space.World);
        //m_whatToRotate.Rotate(Vector3.forward, Random.Range(m_torqueForceMin, m_torqueForceMax), Space.World);


    }

   
}
