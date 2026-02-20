using Sirenix.OdinInspector;
using Unity.Netcode;
using UnityEngine;

public class Player : NetworkBehaviour
{
    [SerializeField] NetworkObject _nObj;
    [SerializeField] PlayerMovement _move;
    [SerializeField] GameObject _head;

    public NetworkObject Network { get { return _nObj; } }
    public PlayerMovement Move { get {  return _move; } }
    public GameObject Head { get { return _head; } }

    public void Start()
    {
        if (IsOwner)
        {
            GameManager.Instance.SetCam(this);
        }
    }
}
