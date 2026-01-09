using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int currentFrameIndex = 0;
    public bool[] framesVisited = new bool[4];

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void MarkFrameVisited(int index)
    {
        if (index >= 0 && index < framesVisited.Length)
        {
            framesVisited[index] = true;
        }
    }

    public bool AllFramesVisited()
    {
        foreach (bool visited in framesVisited)
        {
            if (!visited)
                return false;
        }
        return true;
    }
}
