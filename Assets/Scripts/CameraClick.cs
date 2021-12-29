using System;
using UnityEngine;

public class CameraClick : MonoBehaviour
{
    [SerializeField] private float scaleX = 20f;

    [SerializeField] private float scaleY = 10f;

    public Action<Ray> Click;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log($"Mouse: {Input.mousePosition}");
            var worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
            var ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
            Debug.Log($"World: {worldPosition}");

            //worldPosition.x *= scaleX;
            //worldPosition.y *= scaleY;

            Click?.Invoke(ray);
        }
    }
}
