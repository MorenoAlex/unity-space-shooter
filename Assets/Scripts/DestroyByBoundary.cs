using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Object.Destroy(other.gameObject);
    }
}
