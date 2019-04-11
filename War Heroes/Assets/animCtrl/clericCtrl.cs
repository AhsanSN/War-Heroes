using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clericCtrl : MonoBehaviour
{

    Animator anim;
    int idleHash = Animator.StringToHash("idle_cleric");
    int walkumpHash = Animator.StringToHash("walk_cleric");
    int attackHash = Animator.StringToHash("attack_cleric");
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
        print("ctrl clerik attacking");
        anim.SetTrigger(attackHash);
    }
}
