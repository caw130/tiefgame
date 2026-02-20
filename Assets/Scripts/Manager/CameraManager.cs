using Unity.Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]CinemachineCamera _cam;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCam(Player player)
    {
        _cam.Target.TrackingTarget = player.Head.transform;
    }
}
