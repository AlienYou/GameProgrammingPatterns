using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.DependencyInjection
{
    public interface IDriver 
    {
        void Control(Bike bike);
    }
}
