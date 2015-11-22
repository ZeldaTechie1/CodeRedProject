using UnityEngine;
using System.Collections;


using VibrationType = Thalmic.Myo.VibrationType;

public class Vibration : MonoBehaviour {

    Splitter split;
    ColorBoxByPose vib;
    ThalmicMyo thalmicMyo;
    public GameObject myo;

	// Use this for initialization
	void Start () {
        split = GetComponent<Splitter>();
        vib = GetComponent<ColorBoxByPose>();
	}
	
	// Update is called once per frame
	void Update () {
        thalmicMyo = myo.GetComponent<ThalmicMyo>();
        if (split.splitted)
        {
            Debug.Log("splitted");
            thalmicMyo.Vibrate(VibrationType.Long);
            vib.vibe = true;
        }

	}
}
