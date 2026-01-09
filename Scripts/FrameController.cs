using UnityEngine;

public class FrameController : MonoBehaviour
{
    public int frameIndex;

    void Start()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.currentFrameIndex = frameIndex;
            GameManager.Instance.MarkFrameVisited(frameIndex);
        }
    }

    public void TriggerFailure()
    {
        Debug.Log("Frame ended in failure by design.");

        if (GameManager.Instance != null)
        {
            GameManager.Instance.MarkFrameVisited(frameIndex);
        }
    }
}
