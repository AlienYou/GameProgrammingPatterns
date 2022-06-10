using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer
{
    public class Timer : MonoBehaviour
    {
        private float duration = 10.0f;
        private float halfTime;

        public delegate void TimerBegin();
        public static event TimerBegin onTimerStarted;

        public delegate void HalfTime();
        public static HalfTime onHalfTime;

        public delegate void TimerEnded();
        public static TimerEnded onTimerEnded;

        private IEnumerator coroutine;

        IEnumerator Start()
        {
            halfTime = duration / 2;

            if (onTimerStarted != null)
            {
                onTimerStarted();
            }

            yield return StartCoroutine(WaitAndPrint(1.0f));

            if (onTimerEnded != null)
            {
                onTimerEnded();
            }
        }

        private IEnumerator WaitAndPrint(float waitTime)
        {
            while (Time.time < duration)
            {
                yield return new WaitForSeconds(waitTime);

                Debug.Log($"Seconds: {Mathf.Round(Time.time)}");

                if (Mathf.Round(Time.time) == Mathf.Round(halfTime))
                {
                    if (onHalfTime != null)
                    {
                        onHalfTime();
                    }
                }
            }
        }
    }
}
