using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnterTriggerComponent : MonoBehaviour
{
    [SerializeField] private UnityEvent _action;
    [SerializeField] private string _tag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(_tag))
        {
            _action?.Invoke();
        }
    }
}
