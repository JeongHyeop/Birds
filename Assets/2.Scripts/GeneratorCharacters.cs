using UnityEngine;
using System.Collections;

using Assets.ReadOnly;
using Assets.Character;
using Assets.UI;

public class GeneratorCharacters : MonoBehaviour {

    public YellowBird player = null;

	void Start () {
       PlayerInfoAlam.Notify(PlayerAlamType.ReFresh, player.info);  
	}

	private void Update () {
       player.info.MoveSpeed();
       PlayerInfoAlam.Notify(PlayerAlamType.MoveSpeed, player.info);       
    }
}
