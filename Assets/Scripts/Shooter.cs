using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float rayLength = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayLength))
            {
                Debug.DrawLine(ray.origin, hit.point, Color.red, 1f);

                Vector3 reflectDir = Vector3.Reflect(ray.direction, hit.normal);
                Debug.DrawRay(hit.point, reflectDir * rayLength, Color.green, 1f);
            }
        }
    }
}