using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    public GameObject prefabProjectile;
    public GameObject launchPoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aiming;

    private void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);
        launchPos = launchPointTrans.position;
    }

    private void OnMouseDown()
    {
        aiming = true;
        projectile = Instantiate(prefabProjectile) as GameObject;
        projectile.transform.position = launchPos;
        projectile.GetComponent<Rigidbody>().isKinematic = true;
    }

    // Start is called before the first frame update
    void OnMouseEnter()
    {
        launchPoint.SetActive(true);
    }

    // Update is called once per frame
    void OnMouseExit()
    {
        launchPoint.SetActive(false);
    }
}
