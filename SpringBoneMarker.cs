using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringBoneMarker : MonoBehaviour
{
    public bool CheckHasChildren()
    {
        return transform.childCount != 0;
    }

    public void MarkChildren()
    {
        if (CheckHasChildren())
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                GameObject child = transform.GetChild(i).gameObject;
                if (child.transform.childCount != 0)
                {
                    if (child.GetComponent<SpringBoneMarker>() == null)
                    {
                        child.AddComponent<SpringBoneMarker>();
                        child.GetComponent<SpringBoneMarker>().MarkChildren();
                    }

                }
            }
        }
    }

    public UnityChan.SpringBone AddSpringBone()
    {
        UnityChan.SpringBone springBone = gameObject.AddComponent<UnityChan.SpringBone>();
        springBone.child = gameObject.transform.GetChild(0);
        return springBone;

    }

    public void UnmarkSelf()
    {
        DestroyImmediate(this);
    }
}
