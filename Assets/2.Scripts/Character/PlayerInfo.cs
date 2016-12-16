using UnityEngine;
using System.Collections;

namespace Assets.Character
{
    public class PlayerInfo
    {
        public string characterName;
        public float moveSpeed;

        public virtual void MoveSpeed() { }
    }
}