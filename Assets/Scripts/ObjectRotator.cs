using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public float rotationSpeed = 30f;
    public Vector3 rotationAxis = new Vector3(1f, 1f, 1f);

    void Update()
    {
        transform.RotateAround(
            transform.parent ? transform.parent.position : transform.position,
            rotationAxis.normalized,
            rotationSpeed * Time.deltaTime
        );
    }
}