using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Buff { }
public enum DeBuff { }

public class CharacterHealth : MonoBehaviour {
    public float myHitPoints;

    public float GetHitPoints() {
        return myHitPoints;
    } public void SetHitPoints(float setVal) {
        myHitPoints = setVal;
    }
}
