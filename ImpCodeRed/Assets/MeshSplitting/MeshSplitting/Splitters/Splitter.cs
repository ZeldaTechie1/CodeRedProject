using UnityEngine;

[AddComponentMenu("Mesh Splitting/Splitter")]
[RequireComponent(typeof(Collider))]
public class Splitter : MonoBehaviour
{
    protected Transform _transform;
    public GameObject myo = null;
    GameManager manager;
    //ThalmicMyo myo = null;

    protected virtual void Awake()
    {
        _transform = GetComponent<Transform>();
        GetComponent<Collider>().isTrigger = true;
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        MonoBehaviour[] components = other.GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour component in components)
        {
            
            ISplitable splitable = component as ISplitable;
            if (splitable != null)
            {
                SplitObject(splitable, other.gameObject);
                break;
            }
        }
    }

    protected virtual void SplitObject(ISplitable splitable, GameObject go)
    {
        //ThalmicMyo thalmicMyo = col.myo.GetComponent<ThalmicMyo>();
        //thalmicMyo.Vibrate(Thalmic.Myo.VibrationType.Long);
        manager.AddScore();
        splitable.Split(_transform);
    }
}
