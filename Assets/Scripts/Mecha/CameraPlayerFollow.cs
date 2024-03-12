using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerFollow : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 eulerRotation = new Vector3(transform.eulerAngles.x, _player.transform.eulerAngles.y, transform.eulerAngles.z);

        transform.rotation = Quaternion.Euler(eulerRotation);
    }
}
