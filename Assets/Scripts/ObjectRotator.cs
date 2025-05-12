using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 30f;
    public Vector3 rotationAxis = new Vector3(1f, 1f, 1f);

    public void SetRotationSpeed(float speed)
    {
        rotationSpeed = speed;
    }

    void Update()
    {
        transform.RotateAround(
            transform.parent ? transform.parent.position : transform.position,
            rotationAxis.normalized,
            rotationSpeed * Time.deltaTime
        );
    }
}