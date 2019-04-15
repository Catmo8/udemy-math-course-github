using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(this.gameObject);
    }
}
