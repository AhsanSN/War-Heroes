using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soceressCtrl : MonoBehaviour
{

    Animator anim;
    int idleHash = Animator.StringToHash("idle_soceress");
    int walkumpHash = Animator.StringToHash("walk_soceress");
    int attackHash = Animator.StringToHash("attack_soceress");
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

