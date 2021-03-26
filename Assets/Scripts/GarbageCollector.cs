using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCollector : MonoBehaviour
{
    private void Start()
    {
    }
    void Update()
    {
        
        if (this.transform.position.y > Camera.main.orthographicSize)
        {
            Destroy(this.gameObject);
        }
    }
}
