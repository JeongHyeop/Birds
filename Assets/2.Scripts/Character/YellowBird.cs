using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

using Assets.UI;
using Assets.ReadOnly;

namespace Assets.Character
{
    public class YellowBird : CharacterBird
    {        

        public GameObject player = null;
        private PlayerAnim playerAnimator = null;
        private float moveSpeed = 5.0f;
        private PlayerInfoView playerInfoView;

        private Score scoreUI;

        public YellowBird()
        {
            flyBehaviour = new BirdFly();
            SetPlayerInfo();
        }

        void Start()
        {
            playerAnimator = this.GetComponent<PlayerAnim>();
            playerInfoView = GameObject.Find("CharacterInfoView").GetComponent<PlayerInfoView>();
            scoreUI = GameObject.Find("ScoreManager").GetComponent<Score>();
        }

        public void Update()
        {
            moveSpeed += 0.001f;
            playerAnimator.FlyOffAnim();

            scoreUI.DisplayScore(1);

            //플레이어가 떨어지면 게임오버
            if (player.transform.position.y < -5.5f)
            {
                scoreUI.SetBestScore();
                PlayerInfoAlam.Unregister(playerInfoView);                 //옵저버 패턴에서 보내주고 있던 레지스터 해제
                SceneManager.LoadScene("GameOverScene");
            }
            
        }
        //옵저버 패턴 캐릭터 정보 
        public override void SetPlayerInfo()
        {
            info = new YellowBirdInfo();            
        }

        //옵저버 패턴 캐릭터의 속도
        public override void MoveSpeed()
        {
            if (null != info)
            {
                info.MoveSpeed();
            }
        }

        public override void Move(string dir)
        {
            float horizontal = Input.GetAxis("Horizontal");

            if (dir == "Right")
            {               
                player.transform.Translate(moveSpeed*Time.deltaTime, 0, 0);                
            }

            if (dir == "Left")
            {
                player.transform.Translate(-moveSpeed*Time.deltaTime, 0, 0);                
            }        
        }

        public override void Fly()
        {
            player.transform.Translate(0, 0.1f, 0);
            playerAnimator.FlyOnAnim();
        }
        

        void OnTriggerEnter2D(Collider2D coll)
        {
            //플레이어가 지뢰에 부딪히면 게임오버
            if (coll.tag == "Mine")
            {
                scoreUI.SetBestScore();
                PlayerInfoAlam.Unregister(playerInfoView);                 //옵저버 패턴에서 보내주고 있던 레지스터 해제
                SceneManager.LoadScene("GameOverScene");
            }
        }

    }
}