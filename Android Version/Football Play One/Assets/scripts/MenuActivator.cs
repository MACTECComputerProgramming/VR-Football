using System.Collections;
using UnityEngine;

public class MenuActivator : MonoBehaviour {

   /* public float sightlength = 100f;
    public GameObject selectedObj;
    public float hoverForwardDistance = 5f;


    void FixedUpdate()
    {
        RaycastHit seen;
        Ray raydirection = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(raydirection, out seen, sightlength))
        {
            if (seen.collider.tag == "Button")
            {
                if (selectedObj != null && selctedObj != seen.transform.gameObject)
                {
                    GameObject hitObject = seen.transform.GameObject;
                    MoveMenuButton(hitObject);

                }
                SelectedObj = seen.transform.GameOject;
            }
        }
    }

    private void MoveMenuButton(GameObject hitObject)
    {
        vector3 newZ = hitObject.transform.position;
        newZ.z -= hoverForwardDistance;
        slectedObj.transform.position = newZ;

        newZ += hoverForwardDistance * 2;
        hitObject.transform.position = newZ;

    }
    */

}
