using UnityEngine;
using System.Collections;
using Assets.Character;

namespace Assets.Command
{
    public class FlyCommand : PlayerbleCommand
    {
        private CharacterBird player = null;

        public FlyCommand(CharacterBird _player)
        {
            player = _player;
        }
        public override void Execute()
        {
            if (player == null)
            {
                Debug.Log("캐릭터가 없습니다.!");
            }
            player.Fly();
        }
    }
}