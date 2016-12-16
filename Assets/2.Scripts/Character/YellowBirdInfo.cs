using UnityEngine;
using System.Collections;

namespace Assets.Character
{
    public class YellowBirdInfo : PlayerInfo
    {
        public YellowBirdInfo()
        {
            characterName = "노란새";
            moveSpeed = 0;
        }
        public override void MoveSpeed()
        {
            moveSpeed += 0.001f;
        }
    }
}