using UnityEngine;
using System.Collections;

using UnlockType = Thalmic.Myo.UnlockType;
using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using VibrationType = Thalmic.Myo.VibrationType;

public class vibrateNearObject : MonoBehaviour {


    public GameObject myo = null;
    // public GameObject block;
    ThalmicMyo thalmicMyo;

    /*
    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {

        Pose.Fist
        thalmicMyo = myo.GetComponent<ThalmicMyo>();   
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thalmicMyo.Vibrate(VibrationType.Long);
        }  
    }
    */

    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.name == "Cube")
        {
            thalmicMyo.Vibrate(VibrationType.Long);
            Destroy(gameObject);
            Debug.Log("fghgh");

            ExtendUnlockAndNotifyUserAction(thalmicMyo);
        }              
    }

    void ExtendUnlockAndNotifyUserAction(ThalmicMyo myo)
    {
        ThalmicHub hub = ThalmicHub.instance;

        if (hub.lockingPolicy == LockingPolicy.Standard)
        {
            myo.Unlock(UnlockType.Timed);
        }

        myo.NotifyUserAction();
    }
}
