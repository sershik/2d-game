using UnityEngine;

public class Lessens : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;

    [SerializeField]
    private SpriteRenderer _background;

    private ParalaxManager _paralaxManager;


    private void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _background.transform);
    }

    private void Update()
    {
        _paralaxManager.Update();
    }

    private void FixedUpdate()
    { 
        
    }

    private void OnDestroy()
    {
        
    }
}
