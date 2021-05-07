using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scent : MonoBehaviour
{
    [Header("Scent")]
    public Image scentIcon;
    public float cooldown1 = 5;
    bool isCooldown = false;
    public KeyCode scent;
    public Renderer rend;

    void Start()
    {
        scentIcon.fillAmount = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

    void Update()
    {
        ScentAbility();
    }
   
        void ScentAbility()
    {
        if(Input.GetKey(scent) && isCooldown == false)
        {
            isCooldown = true;
            scentIcon.fillAmount = 1;
            rend.enabled = true;
        }

        if(isCooldown)
        {
            scentIcon.fillAmount -= 1 / cooldown1 * Time.deltaTime;

            if(scentIcon.fillAmount <= 0.5)
            {
                rend.enabled = false;
            }

            if(scentIcon.fillAmount <= 0)
            {
                scentIcon.fillAmount = 0;
                isCooldown = false;
            }
        }
    }
   
}
