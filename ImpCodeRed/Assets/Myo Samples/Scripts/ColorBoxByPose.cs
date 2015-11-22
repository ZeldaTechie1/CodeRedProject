using UnityEngine;
using System.Collections;

using VibrationType = Thalmic.Myo.VibrationType;

// Change the material when certain poses are made with the Myo armband.
// Vibrate the Myo armband when a fist pose is made.
public class ColorBoxByPose : MonoBehaviour
{
    private float count = 0.0f;
    private bool pause1 = false;
    private float totalTime = 0;
    private bool testTrig = false;
    private bool contVibe = false;
    // Myo game object to connect with.
    // This object must have a ThalmicMyo script attached.
    public GameObject myo;
    ThalmicMyo TMyo;
    public bool vibe = false;

    // Materials to change to when poses are made.
    //public Material waveInMaterial;
    //public Material waveOutMaterial;
    //public Material doubleTapMaterial;

    // The pose from the last update. This is used to determine if the pose has changed
    // so that actions are only performed upon making them rather than every frame during
    // which they are active.
    //private Pose _lastPose = Pose.Unknown;


    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Fruits")
        {
            Debug.Log("conttt");
            contVibe = true;
        }
        if (other.gameObject.name == "Sphere1")
        {
            testTrig = true;
        }
       
    }

    void OnCollisionExit (Collision col)
    {
        if (col.gameObject.name == "Sphere1")
        {
            testTrig = false;
        }
        if (col.gameObject.name == "Sphere")
        {
            Debug.Log("cont is false");
            contVibe = false;
        }
    }
       
        


    // Update is called once per frame.
    void Update ()
    {
        
        // Access the ThalmicMyo component attached to the Myo game object.
        ThalmicMyo TMyo = myo.GetComponent<ThalmicMyo> ();
        totalTime += Time.deltaTime;
        
        
        

        if (vibe)
        {
            Debug.Log("Vibrate");
            vibe = false;
            TMyo.Vibrate(VibrationType.Medium);
        }

        Debug.Log(vibe);
    }

    // Extend the unlock if ThalmcHub's locking policy is standard, and notifies the given myo that a user action was
    // recognized.

}
