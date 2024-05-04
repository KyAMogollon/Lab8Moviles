using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ObjectPoolStatic : ObjectPool
{
    public int maxQuantity;
    public void Awake()
    {
        base.Start();
        InstantiateObjects();
    }

    public void InstantiateObjects()
    {
        GameObject tmp;
        for (int i = 0; i < maxQuantity; i++)
        {
            tmp = Instantiate(objPref, transform.position, objPref.transform.rotation);
            objectsPool.Add(tmp);
            tmp.transform.SetParent(this.transform);
            tmp.SetActive(false);
        }
    }
    public GameObject RequestBullet()
    {
        for (int i = 0; i < objectsPool.Count; i++)
        {
            if (!objectsPool[i].activeSelf)
            {
                objectsPool[i].SetActive(true);
                return objectsPool[i];
            }
        }
        return null;
    }
}
