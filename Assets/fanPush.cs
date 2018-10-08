using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanPush : MonoBehaviour {

    public animTester tester;
    public bool catIsUp;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "crane")
        {
            print("touch fan");
            if (catIsUp == true)
            {
                tester.CraneBlowUnderCat();
            }
            if (catIsUp == false)
            {
                tester.CraneBlowIntoCat();

            }
        }

     }
 }
    