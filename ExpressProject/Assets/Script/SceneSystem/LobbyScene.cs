using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyScene : BaseScene
{
    protected override void Init()
    {
        base.Init();
        Debug.Log("LoginScene Init");
    }

    protected override void Clear()
    {
        Debug.Log("LoginScene Clear");
    }
}