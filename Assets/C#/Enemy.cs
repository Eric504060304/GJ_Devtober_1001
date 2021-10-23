using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool isFreeze = false;

    private IEnumerator Freeze(float freezeTIme)
    {
        isFreeze = true;
        yield return new WaitForSeconds(freezeTIme);
        isFreeze = false;
    }
}
