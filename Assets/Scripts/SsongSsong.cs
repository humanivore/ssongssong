using UnityEngine;
using UnityEngine.InputSystem;

public class SsongSsong : MonoBehaviour
{
    [SerializeField]
    private SsongSsongActions _ssongSsongActions;
    private bool _isMouseover;
    private Animator _animator;

    void Awake()
    {
        Debug.Log("awaken");
        _animator = gameObject.GetComponent<Animator>(); 
        _ssongSsongActions = new SsongSsongActions();
        _ssongSsongActions.Default.Hold.performed += Hold_performed;
        _ssongSsongActions.Default.Hold.canceled += Hold_canceled;
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
        Debug.Log("mouseover");
    }

    void OnMouseExit()
    {
        _isMouseover = false;
        Debug.Log("mouse exit");
    }

    private void Hold_performed(InputAction.CallbackContext context)
    {
        if(_isMouseover)
        {
            _animator.SetBool("Touch", true);
        } else {
            _animator.SetBool("Touch", false);
        }
    }

    private void Hold_canceled(InputAction.CallbackContext context)
    {
        _animator.SetBool("Touch", false);
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
