using Unity.Netcode;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
    [SerializeField] NetworkObject _nObj;
    void Start()
    {
        Debug.Log(_nObj.OwnerClientId);
    }

    // Update is called once per frame
    public void Move()
    {

    }
}
