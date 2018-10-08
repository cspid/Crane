using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class animTester : MonoBehaviour
{

    public Animator blindsAnim;
    public Animator windowAnim;
    public Animator craneAnim;
    public Animator catAnim;
    public Animator newtonsAnim;
    public Animator baseballAnim;
    public Animator shirtAnim;


    public bool blinds;
    public bool window;
    public bool craneStart;
    public bool craneIntoCat;
    public bool craneUnderCat;

    public bool craneRejection;
    public bool catScare;
    public bool catSwat;
    public bool newtons;
    public bool baseball;
    public bool shirt;

    void Update()
    {
        if (blinds) Blinds();
        if (window) Window();
        if (craneStart) CraneStart();
        if (craneIntoCat) CraneBlowIntoCat();
        if (craneUnderCat) CraneBlowUnderCat();
        if (craneRejection) CraneRejection();
        if (catScare) CatScare();
        if (catSwat) CatSwat();
        if (newtons) Newton();
        if (baseball) Baseball();
        if (shirt) Shirt();

    }
    public void Blinds() 
    {
        blindsAnim.SetTrigger("Blinds");
        blinds = false;
    }
    public void Window()
    {
        print("test");
        windowAnim.SetTrigger("Window");
        window = false;
    }
    public void CraneStart()
    {
        craneAnim.SetTrigger("Crane Start");
        craneStart = false;
    }
    public void CraneBlowIntoCat()
    {
        craneAnim.SetTrigger("Blow into Cat");
        craneIntoCat = false;
    }
    public void CraneBlowUnderCat()
    {
        craneAnim.SetTrigger("Blow Under Cat");
        craneIntoCat = false;
    }
    public void CraneRejection()
    {
        craneAnim.SetTrigger("Crane Rejection");
        craneRejection = false;
    }
    public void CatScare()
    {
        catAnim.SetTrigger("Cat Scare");
        catScare = false;
    }
    public void CatSwat()
    {
        catAnim.SetTrigger("Cat Swat");
        catSwat= false;
    }
    public void Newton()
    {
        newtonsAnim.SetTrigger("Cradle");
        newtons = false;
    }
    public void Baseball()
    {
        baseballAnim.SetTrigger("Baseball");
        baseball = false;
    }
    public void Shirt()
    {
        shirtAnim.SetTrigger("Shirt");
        craneAnim.SetTrigger("Vacuum Flip");
        shirt = false;
    }

   
}
