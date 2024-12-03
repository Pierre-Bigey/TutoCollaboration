using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RVC
{
    public class GrabableHandle : Grabable
    {
        public override void Update()
        {
            base.Update();
            if (!caught)
            {
                transform.localPosition = new Vector3(0, 0, 0);
                transform.localRotation = Quaternion.identity;
            }
        }

        public override void LocalRelease()
        {
            base.LocalRelease();
            transform.localPosition = new Vector3(0, 0, 0);
            transform.localRotation = Quaternion.identity;
        }
    }
}