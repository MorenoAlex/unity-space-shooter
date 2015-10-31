using UnityEngine;
using System.Collections;

public class BGScroller : MonoBehaviour
{

    public float scrollSpeed;
    public float tileSizeZ;

    private Vector3 startPosition;
    private Transform ts;

    void Start()
    {
        ts = GetComponent<Transform>();
        startPosition = ts.position;
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        ts.position = startPosition + Vector3.forward * newPosition;
    }
}