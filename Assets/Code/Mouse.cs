using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Mouse : MonoBehaviour
{
    public Texture2D MouseTest;
    public Texture2D MouseTest1;
    private Camera cam;
    [SerializeField] AudioClip ClickSound;
    [SerializeField] public Animator animator;


    void Start()
    {
        Cursor.SetCursor(MouseTest, Vector2.zero, CursorMode.ForceSoftware);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)){
        AudioSource.PlayClipAtPoint(ClickSound, Vector3.zero);
        Cursor.SetCursor(MouseTest1, Vector2.zero, CursorMode.ForceSoftware);
        animator.SetBool("isplaying",true);
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; 
        animator.bodyPosition = mousePos;
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Cursor.SetCursor(MouseTest, Vector2.zero, CursorMode.ForceSoftware);
            animator.SetBool("isplaying",false);
        }
    }
}
