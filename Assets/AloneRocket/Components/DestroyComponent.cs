using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.AloneRocket.Components
{
    public class DestroyComponent : MonoBehaviour
    {
        public void DestroyObject()
        {
            Destroy(gameObject);
        }       
    }
}
