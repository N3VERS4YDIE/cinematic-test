using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [SerializeField] float rotationSpeed;

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
