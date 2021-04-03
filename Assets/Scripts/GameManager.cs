using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public event EventHandler<FlamingoTakenArgs> FlamingoTaken;
    public class FlamingoTakenArgs : EventArgs
    {
        public int flamingoName;
    }
    public int flamingos = 10;
    public void decrementFlamingos()
    {
        if (flamingos > 1)
        {
            flamingos = flamingos - 1;
            FlamingoTaken?.Invoke(this, new FlamingoTakenArgs { flamingoName = flamingos });
        }
        else
        {
            this.gameObject.GetComponent<SceneSwitch>().SwitchScene(0);
        }

    }
}

