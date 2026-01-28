using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locator : MonoBehaviour
{
public static locator Instance { get; private set; }
public W4Pigeon Pigeon {get; private set;}


private void Awake() {

    GameObject playerObj = GameObject.FindWithTag("Player");
    Pigeon = playerObj.GetComponent<W4Pigeon>();

    if (Instance != null && Instance != this) {
        Destroy(this);
        return;

}
    Instance = this;





}
}