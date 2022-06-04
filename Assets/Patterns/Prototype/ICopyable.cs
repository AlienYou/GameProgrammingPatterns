using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Prototype
{
    public interface ICopyable
    {
        ICopyable Copy();
    }
}

