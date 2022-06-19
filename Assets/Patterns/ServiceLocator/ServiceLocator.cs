using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.Singleton;

namespace Patterns.ServiceLocator
{
    public class ServiceLocator : Singleton<ServiceLocator> 
    {
        private IDictionary<object, object> serviceDict;

        public override void Awake()
        {
            base.Awake();
            FillRegister();
        }

        private void FillRegister()
        {
            serviceDict = new Dictionary<object, object>();
            serviceDict.Add(typeof(LobbyCoordinator), new LobbyCoordinator());
            serviceDict.Add(typeof(CurrencyConverter), new CurrencyConverter());
            serviceDict.Add(typeof(LightingCoordinator), new LightingCoordinator());
        }

        public T GetService<T>()
        {
            try
            {
                return (T)serviceDict[typeof(T)];
            }
            catch
            {
                throw new System.Exception("The requested service is noit found.");
            }
        }
    }
}

