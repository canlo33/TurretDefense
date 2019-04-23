using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAndDestroy : MonoBehaviour
{

    public GameObject destroyAnimation;
    private Transform target;
    public float bulletSpeed = 100f;

    public void SeekForEnemy(Transform _target)
    {
        target = _target;
    }

    private void HitTarget()
    {
        //Instantiate(destroyAnimation, target.position, target.rotation);
        Destroy(gameObject);
        Destroy(target.gameObject);
        return;
    }

     void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = bulletSpeed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            //Bullet Hit the Target
            HitTarget();
        }
        transform.Translate(dir.normalized * distanceThisFrame);
    }

}
