using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicSoundSystem : MonoBehaviour
{
    [SerializeField] private SoundData _data;

    public SoundData Data => _data;
   // [SerializeField] private bool hasCollider;



    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, _data.Range);

        Vector3 direction = transform.forward * 5;
        Gizmos.DrawRay(transform.position, direction);
    }
   // public bool HasCollider => hasCollider;

}
