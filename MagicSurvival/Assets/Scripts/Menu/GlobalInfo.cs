using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInfo : MonoBehaviour
{
    public static int points = 0;
    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
