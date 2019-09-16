using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ani : MonoBehaviour
{
    public Animator anim;
    // Use this for initialization
    void Start()
    {
        StartCoroutine((string)Umerable());


        // anim.enabled = false;
    }



    // Update is called once per frame
    /*  void OnTriggerEnter()
      {
          anim.enabled = true;

      }*/
    public IEnumerable Umerable()
    {
        yield return new WaitForSecondsRealtime(2f);
        anim.enabled = true;
    }
}
