using UnityEngine;
using System.Collections;

namespace Assets.Command
{
    public interface ICommand
    {
        //확장성을 고려해 PlayerbleCommand에서 추상화 함수를 만들어 상속 받아 오버라이드해서 사용 
        void Execute();
    }
}