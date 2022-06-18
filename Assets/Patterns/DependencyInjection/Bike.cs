using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.DependencyInjection
{
    public class Bike : MonoBehaviour
    {
        private IEngine engine;
        private IDriver driver;

        public void SetEngine(IEngine engine)
        {
            this.engine = engine;
        }

        public void SetDriver(IDriver driver)
        {
            this.driver = driver;
        }

        public void StartEngine()
        {
            engine.StartEngine();
            driver.Control(this);
        }

        public void TurnLeft()
        {
            Debug.Log("The bike is turning left");
        }

        public void TurnRight()
        {
            Debug.Log("The bike is turning right");
        }
    }
}
