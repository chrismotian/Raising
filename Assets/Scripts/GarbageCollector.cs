using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCollector : MonoBehaviour
{

    void Update()
    {

        if (this.transform.position.y > Camera.main.orthographicSize)
        {
            Destroy(this.gameObject);
        }
        if (this.transform.position.y < -6)
        {
            this.gameObject.SetActive(false);
        }
    }
}
