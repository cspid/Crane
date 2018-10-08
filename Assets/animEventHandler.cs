using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animEventHandler : MonoBehaviour {

    public animTester tester;

    public void HitCat(){
        tester.catSwat = true;
        print("test");
    }
}
