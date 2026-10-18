
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private Camera Cam;

    public float TargetZoom = 3f;
    public float ZoomSpeed = 3f;

    public float minZoom = 3f;
    public float maxZoom = 6f;

    void Start()
    {
        Cam = GetComponent<Camera>();

        if (Cam != null)
        {
            TargetZoom = Cam.orthographicSize;
        }
    }

    void Update()
    {
        if (Cam == null)
        {
            return;
        }

        float ScrollData = Input.GetAxis("Mouse ScrollWheel");

        TargetZoom -= ScrollData;
        TargetZoom = Mathf.Clamp(TargetZoom, minZoom, maxZoom);

        Cam.orthographicSize = Mathf.Lerp(
            Cam.orthographicSize,
            TargetZoom,
            Time.deltaTime * ZoomSpeed
        );
    }
}
