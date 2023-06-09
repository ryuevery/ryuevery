using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camview_Switcher : MonoBehaviour
{
    public Animator anim;
    public string triggerName;

    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger(triggerName);
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("Default");
    }
}
