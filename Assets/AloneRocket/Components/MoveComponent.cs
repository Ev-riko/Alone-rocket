using UnityEngine;
using UnityEngine.Events;


namespace Assets.AloneRocket.Components
{
    public class MoveComponent : MonoBehaviour
    {
        [SerializeField] private UnityEvent _action;
        [SerializeField] private float _speed;
        [SerializeField] private float _deadZone;

        private void Update()
        {
            transform.position = transform.position + Vector3.left * _speed * Time.deltaTime;
            if (transform.position.x < _deadZone)
            {
                Debug.Log($"x: {transform.position.x}, destroy");
                _action?.Invoke();                
            }
        }

    }
}
