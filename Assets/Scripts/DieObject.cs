using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieObject : MonoBehaviour {
    [Range(1,6)]public int value = 1;

    public void Roll() {
        value = Random.Range(1, 7);
    }

    public int GetValue() {
        return value;
    }
}
