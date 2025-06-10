using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceholderTrigger : MonoBehaviour
{
    public string acceptedTag;            // <- this should appear in Inspector
    public AudioClip successSound;
    public AudioClip failSound;

    private void OnTriggerEnter(Collider other)
    {
        CubeInteraction cube = other.GetComponent<CubeInteraction>();

        if (cube != null)
        {
            if (cube.cubeTag == acceptedTag)
            {
                cube.LockInPlace();
                if (successSound) AudioSource.PlayClipAtPoint(successSound, transform.position);
                PuzzleManager.Instance.CubePlaced();
            }
            else
            {
                cube.ResetPosition();
                if (failSound) AudioSource.PlayClipAtPoint(failSound, transform.position);
            }
        }
    }
}
