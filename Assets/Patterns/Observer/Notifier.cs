using UnityEngine;

namespace Patterns.Observer
{
    public class Notifier : MonoBehaviour
    {
        private void OnEnable()
        {
            Timer.onTimerEnded += ShowGameOverPopUp;
        }

        private void OnDisable()
        {
            Timer.onTimerEnded -= ShowGameOverPopUp;
        }

        void ShowGameOverPopUp()
        {
            Debug.Log("{NOTIFIER} : Show game over pop up!");
        }
    }

}

