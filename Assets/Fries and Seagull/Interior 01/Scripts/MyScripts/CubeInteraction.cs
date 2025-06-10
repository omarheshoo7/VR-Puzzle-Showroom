using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CubeInteraction : MonoBehaviour
{
    public string cubeTag;
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private XRGrabInteractable grab;

    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        grab = GetComponent<XRGrabInteractable>();
    }

    public void ResetPosition()
    {
        transform.position = originalPosition;
        transform.rotation = originalRotation;
    }

    public void LockInPlace()
    {
        grab.enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }
}
