using UnityEngine;
using UnityEngine.Events;

public class EnterCollisionComponent : MonoBehaviour
{
    [SerializeField] private UnityEvent _action;
    [SerializeField] private string _tag;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(_tag))
        {
            _action?.Invoke();
        }
    }
}
