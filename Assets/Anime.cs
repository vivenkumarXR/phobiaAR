using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anime : MonoBehaviour
{
    private Animation anim;
    public void OnClick()
    {
        anim = GetComponent<Animation>();
        anim.Play("cube5");
    }
}
