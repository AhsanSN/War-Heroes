using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class archerCtrl : MonoBehaviour
{

    Animator anim;
    int idleHash = Animator.StringToHash("idle_archer");
    int walkumpHash = Animator.StringToHash("walk_archer");
    int attackHash = Animator.StringToHash("attack_archer");
    int runStateHash = Animator.StringToHash("Base Layer.Run");
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger(idleHash);
    }

    // Update is called once per frame
    void Update()
    {
        
        //anim.SetTrigger(jumpHash);

    }

    public void attack()
    {
        print("ctrl archer attacking");
        anim.SetTrigger(attackHash);
    }
}
