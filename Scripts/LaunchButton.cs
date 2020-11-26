using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchButton : MonoBehaviour
{
    public ResetButton resetButton;
    public void HasLaunched ()
    {
        this.gameObject.SetActive(false);
    }
}
