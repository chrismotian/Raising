using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeFlamingo : MonoBehaviour
{
    GameManager instance;
    private void Start()
    {
        instance = FindObjectOfType<GameManager>();
    }
    private void OnDestroy()
    {
        instance.flamingos = instance.flamingos - 1;
    }
}
