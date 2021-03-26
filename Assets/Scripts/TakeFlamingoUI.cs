using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeFlamingoUI : MonoBehaviour
{
    [SerializeField] int myName = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameManager flamingoTakenEvent = FindObjectOfType<GameManager>();
        flamingoTakenEvent.FlamingoTaken += GameManager_FlamingoTaken;
    }

    void GameManager_FlamingoTaken(object sender, GameManager.FlamingoTakenArgs e)
    {
        Debug.Log("Event");
        if (e.flamingoName == myName) { 
            GameManager flamingoTakekEvent = FindObjectOfType<GameManager>();
            flamingoTakekEvent.FlamingoTaken -= GameManager_FlamingoTaken;
            Destroy(this.gameObject);
        }
    }
}
