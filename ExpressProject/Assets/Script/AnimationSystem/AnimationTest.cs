using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationTest : MonoBehaviour
{
    public Button BtnFishing;
    public Button BtnReel;
    public Button BtnFishigEnd;

    public AnimationActions animationActions;

    private void Start()
    {
        this.BtnFishing.onClick.AddListener(() =>
        {
            animationActions.TakeAction("FishingCast");
        });
        this.BtnReel.onClick.AddListener(() =>
        {
            animationActions.TakeAction("FishingReel");
        });
        this.BtnFishigEnd.onClick.AddListener(() =>
        {
            animationActions.TakeAction("FishingFinish");
        });
    }
}
