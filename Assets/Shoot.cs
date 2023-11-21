using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : StateMachineBehaviour
{

    [SerializeField]
    private ProjectileObject projectile;

    private Rigidbody rGB;

    public float fireRate = 0.3f;
    public float nextFire = 0f;

    //private Vector2 rightDir = Vector2.right;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

    //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Time.time > nextFire) 
        { 
        nextFire = Time.time + fireRate;

        if (projectile.nB < 10)
        {
            Instantiate(projectile);
            projectile.nB++;
            animator.SetInteger("MaxShoot", projectile.nB);
        }
        else
        {
            animator.Play("Reloading");
            projectile.nB = 0;
            animator.SetInteger("MaxShoot", projectile.nB);
        }
        }

        // délai de recharge


    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
