using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _targetXPosition = 3f;
    [SerializeField] private float _duration = 5f;
    [SerializeField] private int _loopCount = -1; 

    private void Start()
    {
        transform.DOMoveX(_targetXPosition, _duration).SetLoops(_loopCount, LoopType.Yoyo);
    }
}