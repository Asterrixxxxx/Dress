using UnityEngine;

public class AudioButton : MonoBehaviour
{
    
    public void Mutebutton(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}
