using UnityEngine;

[RequireComponent(typeof(CameraClick))]
public class Spheres : MonoBehaviour
{
    [SerializeField] private SphereMovement _spherePrefab;

    private CameraClick _camera;

    void Start()
    {
        _camera = GetComponent<CameraClick>();
        _camera.Click += CreateNewSphere;
    }

    private void OnDestroy()
    {
        _camera.Click -= CreateNewSphere;
    }

    private void CreateNewSphere(Ray ray)
    {
        var newSphere = Instantiate(_spherePrefab);
        newSphere.Direct(ray);
    }
}
