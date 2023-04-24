using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    public PlayerMovement _pm;

    public void Left()
    {
        _pm._left = true;
    }

    public void LeftStop()
    {
        _pm._left = false;
    }

    public void Right()
    {
        _pm._right = true;
    }
    public void RightStop()
    {
        _pm._right = false;
    }


}
