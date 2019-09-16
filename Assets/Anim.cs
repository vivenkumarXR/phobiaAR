using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    private Animator anime;
   public void OnClick()
    {
        anime = GetComponent<Animator>();
       anime.Play("cube6");

    }
   
}
