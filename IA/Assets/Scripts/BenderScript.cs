using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BenderScript : MonoBehaviour
{

    public GameObject modelBender;
    public GameObject iniciatePoint;
    Animator anim;
    private int countBenderScreen = 0;

    // Start is called before the first frame update
    void Start()
    {
        string nameBender = string.Concat("bender" + countBenderScreen);
        GameObject bender = new GameObject();
        bender.name = nameBender;
        bender.AddComponent<Rigidbody>();
        bender.AddComponent<Animator>();
        anim = bender.GetComponent<Animator>();
        //anim.SetBool("isRunning", true); // idle

        Instantiate(bender, new Vector3(iniciatePoint.transform.position.x, iniciatePoint.transform.position.y, 0), Quaternion.identity);
        countBenderScreen++;
    }

    // Update is called once per frame
    void Update()
    {
    }

   
}
