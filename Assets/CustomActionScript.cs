using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class CustomActionScript : MonoBehaviour
{

    public SteamVR_Action_Boolean steamVR;
    public SteamVR_Input_Sources handtype;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject righthand;
    [SerializeField] Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        steamVR.AddOnStateDownListener(TriggerDown, handtype);
        steamVR.AddOnStateDownListener(TriggerUp, handtype);
    }
    private void Update()
    {
        rotation = righthand.transform.rotation.eulerAngles+new Vector3(60,0,0);
    }
    // Update is called once per frame
    public void TriggerUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) 
    {
        Debug.Log("up");
    }
    public void TriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("down");
        Instantiate(bullet, righthand.transform.position,righthand.transform.rotation);
    }
}
