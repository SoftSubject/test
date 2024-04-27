using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_01_nav : MonoBehaviour
{
    Animator m_Animator;
    public GameObject panel_content;
    
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    void SetInt(int _i)
    {
        m_Animator.SetInteger("trig_01_select", _i);
    }

    public void Set_Int(int _i)
    {
        if(panel_content.activeInHierarchy)
        {
        }
        else
        {
            Debug.Log("___ not active");
            m_Animator.SetTrigger("trig_01");
        }

        panel_content.transform.GetChild(0).gameObject.SetActive(false);
        panel_content.transform.GetChild(1).gameObject.SetActive(false);
        panel_content.transform.GetChild(2).gameObject.SetActive(false);
        panel_content.transform.GetChild(3).gameObject.SetActive(false);

        panel_content.transform.GetChild(_i-1).gameObject.SetActive(true);
    }


}
