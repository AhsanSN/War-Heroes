using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warriorCtrl : MonoBehaviour
{

    Animator anim;
    int idleHash = Animator.StringToHash("idle_warrior");
    int walkumpHash = Animator.StringToHash("walk_warrior");
    int attackHash = Animator.StringToHash("attack_warrior");
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

    public void doattack()
    {
        print("ctrl warrior attacking");
        anim.SetTrigger(attackHash);
    }


}

