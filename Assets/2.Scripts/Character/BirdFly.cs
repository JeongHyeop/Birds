using UnityEngine;
using System.Collections;

namespace Assets.Character
{
    public class BirdFly : FlyBehaviour
    {
        public virtual void Fly()
        {
            transform.Translate(0, 1.0f, 0);
        }
    }
}