using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class TestTimeScript : MonoBehaviour
{
    [SerializeField] private PostProcessLayer postProcessLayer;

    public TimeBarControl timeBar;
    // public GameObject postProcessVolume;
    // Start is called before the first frame update
    void Start()
    {
        SetPostProcessingLayerIsEnabled(false);//true or false
    }

    public void FixedUpdate()
    {
        if (timeBar.currentTime > 0)
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
        else if(timeBar.currentTime <= 0)
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
