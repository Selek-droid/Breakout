using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameKeeper : MonoBehaviour
{
    public static NameKeeper singleInstance;
    public static string storedUsername;

    private void Awake()
    {
        singleInstance = this;
        DontDestroyOnLoad(gameObject);
    }
}
