using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    Player _player;
    void OnMove(InputValue value)
    {
        Debug.Log(value.Get<Vector2>());
    }
    void OnMouse(InputValue value)
    {
        Debug.Log(value.Get<Vector2>());
    }

    public void GetPlayer(Player player)
    {
        if (player.IsOwner)
        {
            _player = player;
        }
    }
}
