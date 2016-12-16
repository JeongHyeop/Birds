using UnityEngine;
using System.Collections;
using Assets.Character;

namespace Assets.Command
{
    public class MoveCommand : PlayerbleCommand
    {
        private CharacterBird player    = null;
        private string dir              = null;

        public MoveCommand(CharacterBird _player, string _dir)
        {
            player = _player;
            dir = _dir;
        }

        public override void Execute()
        {
            if (player == null)
            {
                Debug.Log("캐릭터가 없습니다.!");
            }
            player.Move(dir);
        }

    }
}