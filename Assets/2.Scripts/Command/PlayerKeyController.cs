using UnityEngine;
using System.Collections;
using Assets.Character;
using Assets;
namespace Assets.Command
{
    public class PlayerKeyController : MonoBehaviour
    {
        //캐릭터 추가
        private CharacterBird player = null;
        string dir = null;

        void Start()
        {
            player = this.GetComponent<CharacterBird>();
        }

        void Update()
        {
            //플레이어 Right로 움직임
            if (Input.GetKey(KeyCode.RightArrow))
            {
                dir = "Right";
                var command = new MoveCommand(player, dir);
                command.Execute();
            }

            //플레이어 Left로 움직임
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                dir = "Left";
                var command = new MoveCommand(player, dir);
                command.Execute();
            }

            if (Input.GetKey(KeyCode.Space))
            {              
                var command = new FlyCommand(player);
                command.Execute();
            }
        }

    }
}