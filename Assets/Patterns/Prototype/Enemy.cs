using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Prototype
{
    public class Enemy : MonoBehaviour, ICopyable
    {
        public ICopyable Copy()
        {
            return Instantiate(this);
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
