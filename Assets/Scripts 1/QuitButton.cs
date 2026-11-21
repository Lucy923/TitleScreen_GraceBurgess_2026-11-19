using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public void ExitApp()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
