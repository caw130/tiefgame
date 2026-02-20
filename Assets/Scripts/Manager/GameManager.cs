using System.Collections.Generic;
using Unity.Netcode;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : NetworkBehaviour
{
    public static GameManager Instance = null;
    [SerializeField] SpawnManager _spawnManager;
    [SerializeField] CameraManager _camManager;
    [SerializeField] List<Player> _players ;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    public override void OnNetworkSpawn()
    {
        if (IsServer)
        {
            NetworkManager.Singleton.OnClientConnectedCallback += playerConnected;
        }
    }

    void playerConnected(ulong userId)
    {
        Player player =_spawnManager.Spawn(userId);
        _players.Add(player);
    }

    public void SetCam(Player player)
    {
        _camManager.SetCam(player);
    }
}
