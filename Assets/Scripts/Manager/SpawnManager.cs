using Sirenix.OdinInspector;
using Unity.Netcode;
using UnityEngine;

public class SpawnManager : NetworkBehaviour
{
    [AssetsOnly]
    [SerializeField]Player _playerPrefab;
    
    
    public Player Spawn(ulong userId)
    {
        Debug.Log(userId);
        Player player = Instantiate(_playerPrefab);
        player.transform.position = Vector3.zero;
        player.Network.SpawnAsPlayerObject(userId);
        return player;
    }
}
