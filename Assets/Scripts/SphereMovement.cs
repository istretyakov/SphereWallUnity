using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SphereMovement : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;

    private Rigidbody _rigidbody;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Direct(Ray ray)
    {
        transform.position = ray.origin;

        _direction = ray.direction * 1500;

        Move();
    }

    private void Move()
    {
        _rigidbody.AddForce(_direction);
    }
}
