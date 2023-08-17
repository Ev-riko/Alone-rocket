using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Assets.AloneRocket.Components
{
    public class Cosmonavt : MonoBehaviour
    {
        [SerializeField] private float _magnetismPower;
        [SerializeField] private float _magnetismRadius;
        private Rocket _rocket;
        private bool _isNearby;

        private void Start()
        {
            _rocket = FindAnyObjectByType<Rocket>();
        }

        private void Update()
        {
            var position = transform.position;

            var positionDelta = _rocket.transform.position - position;

            _isNearby = positionDelta.magnitude < _magnetismRadius;


            if (_isNearby)
            {
                Debug.Log("magnetism");
                position += positionDelta.normalized * _magnetismPower * Time.deltaTime;
                transform.position = position;
            }
        }


#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            Handles.color = _isNearby ? new Color(0, 1f, 0, 0.1f) : new Color(1f, 0, 0, 0.1f);
            Handles.DrawSolidDisc(transform.position, Vector3.forward, _magnetismRadius);
        }

#endif
    }

}
