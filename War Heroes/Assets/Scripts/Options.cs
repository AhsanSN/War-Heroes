using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public GameObject startbutton;
    public GameObject quitbutton;
    public GameObject optionsbutton;
    public GameObject rhombus;
    public GameObject Tooltips;
    public GameObject back;
    public GameObject text;
    private Animation anim_start_up;
    private Animation anim_quit_up;
    private Animation anim_options_selected;
    private Animation anim_rhombus;
    private Animation anim_text;
    private Animation anim_tooltips;
    private Animation anim_back;
    private Button options;
    private bool OptionsSelected = false;

    void Start()
    {
        anim_start_up = startbutton.GetComponent<Animation>();
        anim_quit_up = quitbutton.GetComponent<Animation>();
        anim_options_selected = optionsbutton.GetComponent<Animation>();
        anim_rhombus = rhombus.GetComponent<Animation>();
        anim_text = text.GetComponent<Animation>();
        anim_tooltips = Tooltips.GetComponent<Animation>();
        anim_back = back.GetComponent<Animation>();
        options = optionsbutton.GetComponent<Button>();
    }

    public void OpenOptions() {
        if (OptionsSelected == false)
        {
            anim_start_up.Play("Move up 1");
            anim_options_selected.Play("OptionsSelected");
            anim_quit_up.Play("Move up");
            anim_rhombus.Play("extend");
            anim_text.Play("Volume up");
            anim_tooltips.Play("Tooltips up");
            anim_back.Play("back");
            FindObjectOfType<AudioManager>().play("Select");
            options.interactable = false;
            OptionsSelected = true;
        }
    }

    public void CloseOptions()
    {
        if (OptionsSelected == true)
        {
            anim_start_up.Play("drop down");
            anim_options_selected.Play("OptionsDeselected");
            anim_quit_up.Play("drop down 2");
            anim_rhombus.Play("contract");
            anim_text.Play("Volume down");
            anim_tooltips.Play("Tooltips down");
            anim_back.Play("back off");
            FindObjectOfType<AudioManager>().play("Select");
            options.interactable = true;
            OptionsSelected = false;
        }
    }
}
