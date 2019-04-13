using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public AttributeManager.SkillAttributes doorType;

    void OnCollisionEnter(Collision collision)
    {
        if((collision.gameObject.GetComponent<AttributeManager>().attributes & (int)doorType) != 0)
        {
            this.GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        this.GetComponent<BoxCollider>().isTrigger = false;
        other.gameObject.GetComponent<AttributeManager>().attributes &= ~(int)doorType;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
