using UnityEngine;

public class SlowTimeManager : MonoBehaviour
{
    public float slowdFactor = 0.05f;
    public float slowLength = 2f;
    // Start is called before the first frame update

    void Update()
    {
        // 
        Time.timeScale += (1f / slowLength) * Time.unscaledDeltaTime;
        Time.fixedDeltaTime += (0.01f / slowLength) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
        Time.fixedDeltaTime = Mathf.Clamp(Time.fixedDeltaTime, 0f, 0.01f);
    }
    public void SlowMotion()
    {
        Time.timeScale = slowdFactor;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowdFactor;
    }

    public void StopSlowMotion()
    {
        Time.timeScale = 1; 
    }
}
