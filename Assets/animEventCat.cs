using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animEventCat : MonoBehaviour {

    public animTester tester;
    public fanPush fan;


    public void Swat(){
        tester.CraneRejection();
    }
    public void isUp()
    {
        print("up");
        fan.catIsUp = true;
    }
    public void isDown()
    {
        print("down");
        fan.catIsUp = false;
    }



}
