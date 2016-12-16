using UnityEngine;
using System.Collections;
using Assets.Command;

public class PlayerAnim : MonoBehaviour {
    public Animator animator;

    public void FlyOnAnim()
    {
        animator.SetBool("FlyOnAnim",true);
    }
    public void FlyOffAnim()
    {
        animator.SetBool("FlyOnAnim", false);
    }

}
