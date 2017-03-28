using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        Vector3 position = transform.position;

    position.x -= Time.deltaTime + speed;

        transform.position = position;
        }
}