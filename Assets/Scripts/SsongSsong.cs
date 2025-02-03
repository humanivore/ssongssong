using UnityEngine;
using UnityEngine.InputSystem;

public class SsongSsong : MonoBehaviour
{
    [SerializeField]
    private SsongSsongActions _ssongSsongActions;
    private bool _isMouseover;

    void Awake()
    {
        _ssongSsongActions = new SsongSsongActions();
        _ssongSsongActions.Default.Hold.performed += Hold_performed;
    }

    private void OnEnable()
    {
        _ssongSsongActions.Default.Enable();
    }

    private void OnDisable()
    {
        _ssongSsongActions.Default.Disable();
    }

    void OnMouseOver()
    {
        _isMouseover = true;
    }

    void OnMouseExit()
    {
        _isMouseover = false;
    }

    private void Hold_performed(InputAction.CallbackContext context)
    {
        Vector3 now = transform.position;
        if(_isMouseover)
        {
            Vector3 target = transform.position;
            target.y = now.y + 1;
            transform.position = Vector3.MoveTowards(now, target, 1);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
