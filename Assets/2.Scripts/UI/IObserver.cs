using UnityEngine;
using System.Collections;

namespace Assets.UI
{
    public interface IObserver<T, T2>
    {
        void OnEvent(T eventType, T2 data);
    }
}