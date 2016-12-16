using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.ReadOnly;
using Assets.Character;

namespace Assets.UI
{
    using PlayerAlarm = IObserver<PlayerAlamType, PlayerInfo>;

    public class PlayerInfoAlam
    {
        private static PlayerInfoAlam instance = new PlayerInfoAlam();

        public static bool Register(PlayerAlarm target)
        {
            return instance.Add(target);
        }

        public static bool Unregister(PlayerAlarm delTarget)
        {
            return instance.Delete(delTarget);
        }

        public static void Notify(PlayerAlamType type, PlayerInfo data)
        {
            instance.OnNotify(type, data);
        }

        private List<PlayerAlarm> observers = new List<PlayerAlarm>();

        public bool Add(PlayerAlarm addTarget)
        {
            if (false == observers.Contains(addTarget))
            {
                observers.Add(addTarget);
                return true;
            }
            return false;
        }

        public bool Delete(PlayerAlarm delTarget)
        {
            if (true == observers.Contains(delTarget))
            {
                observers.Remove(delTarget);
                return true;
            }
            return false;
        }

        public void OnNotify(PlayerAlamType type, PlayerInfo data)
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].OnEvent(type, data);
            }
        }

    }
}