using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class TestTimeScript : MonoBehaviour
{
    [SerializeField] private PostProcessLayer postProcessLayer;

    // public GameObject postProcessVolume;
    // Start is called before the first frame update
    void Start()
    {
        SetPostProcessingLayerIsEnabled(false);//true or false
    }

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            SetPostProcessingLayerIsEnabled(true);
        }
        else
        {
            SetPostProcessingLayerIsEnabled(false);
        }
       
    }
    public void SetPostProcessingLayerIsEnabled(bool _value)
    {
        if (postProcessLayer == null) return;
        postProcessLayer.enabled = _value;
    }
}
