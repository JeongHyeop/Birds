using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.ReadOnly;
using Assets.Character;

namespace Assets.UI
{
    public class PlayerInfoView : MonoBehaviour
                                 , IObserver<PlayerAlamType, PlayerInfo>
    {
        public Text playerName  = null;
        public Text playerSpeed = null;

        private string argFormat      = "{0}: {1}";
        private string speedArgFormat = "{0}: {1:f2}";

        private void Awake()
        {
            Debug.Assert(null != playerName);
            Debug.Assert(null != playerSpeed);

            InitText();

            PlayerInfoAlam.Register(this);            
        }

        public void InitText()
        {
            playerName.text = string.Format(argFormat, "NAME", string.Empty);
            playerSpeed.text = string.Format(speedArgFormat, "SPEED", 0.0f);
        }
  
        public void OnEvent(PlayerAlamType type, PlayerInfo data)
        {
            if (data != null)
            {                
                playerName.text = string.Format(argFormat, "NAME", data.characterName);
                playerSpeed.text = string.Format(speedArgFormat, "SPEED", data.moveSpeed);
            }
        }

    }
}