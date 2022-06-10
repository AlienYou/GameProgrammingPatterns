using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer
{
    public class WarningLight : MonoBehaviour
    {
        private void OnEnable()
        {
            Timer.onHalfTime += BlinkLight;
        }

        private void OnDisable()
        {
            Timer.onHalfTime -= BlinkLight;
        }

        void BlinkLight()
        {
            Debug.Log("{WARNING_LIGHT} : It's a half-time, blinking the warning light");
        }
    }
}
