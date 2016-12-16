using UnityEngine;
using System.Collections;

namespace Assets.Character
{
    public abstract class CharacterBird : MonoBehaviour
    {
        //캐릭터 추가를 고려해서 스트레티지 패턴을 사용
        //팩토리 패턴도 좋지만 bird만을 이용할 것이기 때문에

        protected FlyBehaviour flyBehaviour;

        //각각 받아온 Fly함수를 실행
        public void PerformFly()
        {
            flyBehaviour.Fly();
        }
        
        public virtual void Move(string dir) { }

        public virtual void Fly() { }
        public virtual void MoveSpeed() { }
        public virtual void SetPlayerInfo() { }

        public PlayerInfo info { get; protected set; }

        //Set함수로 여러 새의 Fly하는 것을 받아옴
        public void SetFlyBehavior(FlyBehaviour _flyBehaviour)
        {
            flyBehaviour = _flyBehaviour;
        }
    }
}