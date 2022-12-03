using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScrolling : MonoBehaviour
{
    [SerializeField] private Transform player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 cameraPos = transform.position;
        cameraPos.x = Mathf.Max(cameraPos.x, player.position.x);
        cameraPos.z = -10;
        transform.position = cameraPos;
    }
}
