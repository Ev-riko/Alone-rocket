using UnityEngine;

public class SpawnComponent : MonoBehaviour
{
    [SerializeField] private GameObject[] _prefabs;
    [SerializeField] private float _spawnRate;
    [SerializeField] private float _heightOffset;
    

    private float _time;
    private int _prefabsCount;
    private Vector3 _position;

    void Start()
    {
        _prefabsCount = _prefabs.Length;
        _position = transform.position;
    }

    void Update()
    {
        if (_time < _spawnRate)
        {
            _time += Time.deltaTime;
        }
        else
        {
            SpawnObject(Random.Range(0, _prefabsCount), Random.Range(_position.y - _heightOffset, _position.y + _heightOffset));
            _time = 0;
        }
    }

    private void SpawnObject(int index, float y)
    {
        
        var rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        Instantiate(_prefabs[index], new Vector3(transform.position.x, y), rotation);
    }
}
