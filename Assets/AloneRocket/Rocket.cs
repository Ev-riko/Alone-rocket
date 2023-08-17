using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed;

    private Vector2 _direction;
    private int _score;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public int GetScore()
    {
        return _score;
    }

    public void AddScore()
    {
        _score++;
        Debug.Log(_score);
    }

    void FixedUpdate()
    {
        _rigidbody2D.velocity += _direction * _speed;
        _rigidbody2D.rotation = Mathf.Lerp(_rigidbody2D.rotation, _rigidbody2D.velocity.y * 10, 0.5f);
    }

    public void SetDirectoin(Vector2 direction)
    {
        _direction = direction;
    }
}
