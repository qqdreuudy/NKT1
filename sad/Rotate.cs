
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [Header("物体旋转的速度"), SerializeField] private float _RotationSpeed;
    private float shake;
    private int _i = 0;
    private MeshRenderer BoxColliderClick;
    void Start()
    {
        BoxColliderClick = gameObject.transform.GetChild(_i).GetComponent<MeshRenderer>();
        gameObject.transform.tag = gameObject.transform.GetChild(_i).tag;
        v1 = new Vector3(3, 4, 5);
        Vector3 v2 = v1.normalized;
        Debug.Log(v2);
    }

    void Update()
    {
        // transform.Rotate(Vector3.down*_RotationSpeed,Space.World);

        shake += Time.deltaTime;

        if (shake % 1 > 0.5f)
        {
            BoxColliderClick.enabled = true;
            gameObject.transform.tag = gameObject.transform.GetChild(_i).tag;
        }
        else
        {
            BoxColliderClick.enabled = false;
        }

    }

    public void getmesh(int i)
    {
        _i = i;
        BoxColliderClick.enabled = true;
        BoxColliderClick = gameObject.transform.GetChild(i).GetComponent<MeshRenderer>();
    }

    public Vector3 v1;

}
