using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.AloneRocket.Components
{
    public class Cosmonavt : MonoBehaviour
    {
        
        [SerializeField] private float _magnetismPower;
        private Rocket _rocket;

        private void Start()
        {
            _rocket = FindAnyObjectByType<Rocket>();
        }

        private void Update()
        {
            var position = transform.position;

            var positionDelta = _rocket.transform.position - position;

            position += positionDelta.normalized * (_magnetismPower / Mathf.Max(_magnetismPower, positionDelta.magnitude));

            transform.position = position;
        }
    }

}
