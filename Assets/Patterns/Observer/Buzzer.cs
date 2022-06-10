using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer
{
    public class Buzzer : MonoBehaviour
    {
        private void OnEnable()
        {
            Timer.onTimerStarted += PlayStartBuzzer;
            Timer.onTimerEnded += PlayEndBuzzer;
        }

        private void OnDisable()
        {
            Timer.onTimerStarted -= PlayStartBuzzer;
            Timer.onTimerEnded -= PlayEndBuzzer;
        }

        void PlayStartBuzzer()
        {
            Debug.Log("{BUZZER} : Play start buzzer!");
        }

        void PlayEndBuzzer()
        {
            Debug.Log("{BUZZER} : Play end buzzer!");
        }
    }
}
