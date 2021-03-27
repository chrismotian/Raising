using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnClick : MonoBehaviour
{
    Collider2D disableCollider = null;
    private void Start()
    {
        disableCollider = FindObjectOfType<GameManager>().GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || (Input.touchCount >= 1 && Input.touches[0].phase == TouchPhase.Began))
        {
            if (disableCollider.OverlapPoint(this.transform.position))
            {
                this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
                Destroy(this);
            }
        }
    }
}
