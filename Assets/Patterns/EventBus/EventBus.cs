using UnityEngine;
using Patterns.Singleton;
using System.Collections.Generic;
using UnityEngine.Events;

namespace Patterns.EventBus
{
    public class EventBus : Singleton<EventBus> 
    {
        private Dictionary<string, UnityEvent> eventDictionary;
        public override void Awake()
        {
            base.Awake();
            Instance.Init();
        }

        private void Init()
        {
            if (Instance.eventDictionary == null)
            {
                Instance.eventDictionary = new Dictionary<string, UnityEvent>();
            }
        }

        public static void StartListening(string eventName, UnityAction listener)
        {
            UnityEvent thisEvent = null;
            if (Instance.eventDictionary.TryGetValue(eventName, out thisEvent))
            {
                thisEvent.AddListener(listener);
            }
            else
            {
                thisEvent = new UnityEvent();
                thisEvent.AddListener(listener);
                Instance.eventDictionary.Add(eventName, thisEvent);
            }
        }

        public static void StopListening(string eventName, UnityAction listener)
        {
            UnityEvent thisEvent = null;
            if (Instance.eventDictionary.TryGetValue(eventName, out thisEvent))
            {
                thisEvent.RemoveListener(listener);
            }
        }

        public static void TriggerEvent(string eventName)
        {
            UnityEvent thisEvent = null;
            if (Instance.eventDictionary.TryGetValue(eventName, out thisEvent))
            {
                thisEvent.Invoke();
            }
        }
    }
}
