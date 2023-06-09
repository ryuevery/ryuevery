using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationLayerController : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            bool v = anim.GetBool("Shooting");
            int idx = anim.GetLayerIndex("Shooting");
            if (v == false)
            {
                anim.SetBool("Shooting", true);
                anim.SetLayerWeight(idx, 1.0f);
            }
            else
            {
                anim.SetBool("Shooting", false);
                anim.SetLayerWeight(idx, 0.0f);
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine("GetWorse");

        }
    }
    IEnumerator GetWorse()
    {
        float weight = anim.GetLayerWeight(2);
        while (weight <= 1.0f)
        {
            weight = Mathf.Lerp(weight, 1.0f, Time.deltaTime / 50f);
            anim.SetLayerWeight(2, weight);
            yield return null;
        }
    }
}