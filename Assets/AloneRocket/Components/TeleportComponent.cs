using UnityEngine;

public class TeleportComponent : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private float _heightOffset;

    public void Teleport(int distance)
    {
        var teleportDestination = _gameObject.transform.position;
        teleportDestination += Vector3.right * distance;
        teleportDestination.y = Random.Range(-_heightOffset, _heightOffset);
        _gameObject.transform.position = teleportDestination;
    }      
}