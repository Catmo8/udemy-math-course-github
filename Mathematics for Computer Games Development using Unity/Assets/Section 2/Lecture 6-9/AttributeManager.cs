using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AttributeManager : MonoBehaviour
{
    public enum SkillAttributes
    {
        MAGIC = 16,
        INTELLIGENCE = 8,
        CHARISMA = 4,
        FLY = 2,
        INVISIBLE = 1,
    }
    //static public int MAGIC = 16;
    //static public int INTELLIGENCE = 8;
    //static public int CHARISMA = 4;
    //static public int FLY = 2;
    //static public int INVISIBLE = 1;

    public Text attributeDisplay;
    public int attributes = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "MAGIC")
        {
            attributes |= (int)SkillAttributes.MAGIC;
        }
        else if (other.gameObject.tag == "INTELLIGENCE")
        {
            attributes |= (int)SkillAttributes.INTELLIGENCE;
        }
        else if (other.gameObject.tag == "CHARISMA")
        {
            attributes |= (int)SkillAttributes.CHARISMA;
        }
        else if (other.gameObject.tag == "FLY")
        {
            attributes |= (int)SkillAttributes.FLY;
        }
        else if (other.gameObject.tag == "INVISIBLE")
        {
            attributes |= (int)SkillAttributes.INVISIBLE;
        }
        else if (other.gameObject.tag == "ANTIMAGIC")
        {
            attributes &= ~(int)SkillAttributes.MAGIC;
        }
        else if (other.gameObject.tag == "REMOVE")
        {
            attributes &= ~ ((int)SkillAttributes.INTELLIGENCE | (int)SkillAttributes.MAGIC);
        }
        else if (other.gameObject.tag == "ADD")
        {
            attributes |= ((int)SkillAttributes.INTELLIGENCE | (int)SkillAttributes.MAGIC | (int)SkillAttributes.CHARISMA);
        }
        else if (other.gameObject.tag == "RESET")
        {
            attributes = 0;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        attributeDisplay.transform.position = screenPoint + new Vector3(0,-50,0);
        attributeDisplay.text = Convert.ToString(attributes, 2).PadLeft(8, '0');
    }
       
}
