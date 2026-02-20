using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class TestUi : MonoBehaviour
{
    [SerializeField] Button _host;
    [SerializeField] Button _server;
    [SerializeField] Button _client;
    [SerializeField] Button _disconnet;
    [SerializeField] Button _close;
    void Awake()
    {
        _host.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartHost();
        });
        _server.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartServer();
        });
        _client.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartClient();
        });
        _close.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }
}
