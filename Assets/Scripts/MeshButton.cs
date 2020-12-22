using System.Collections;
using UnityEngine;
[RequireComponent(typeof(MeshCollider))]

public class MeshButton : MonoBehaviour
{
    private OnClickHandler clickHandler;
    public Material Lit;
    public Material Unlit;
    private MeshRenderer MR;
   // private Rigidbody rb;

   // private Vector3 screenPoint;
    //private Vector3 offset;
   // private Vector3 curPosition;
   // private Vector3 curScreenPoint;

   // private float speed = 25f;
   // private float hor;
  // private float ver;

    private void Start()
    {
        clickHandler = GetComponentInParent<OnClickHandler>();
        MR = GetComponent<MeshRenderer>();
       // rb = GetComponent<Rigidbody>();
    }

   // private void Update()
    //{
     //   hor = Input.GetAxis("Mouse X");
     //  ver = Input.GetAxis("Mouse Y");
    //}

    void OnMouseDown()
    {
        //  screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        //offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        clickHandler.RecieveClicks(this);
        Debug.Log(gameObject.name);
    }
   // IEnumerator LightUp()
  //  {
        
   // }
   void OnMouseDrag()
    {
        MR.material = Lit;
        //curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        //curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        // transform.position = curPosition;
    }
    
   private void OnMouseUp()
   {
        MR.material = Unlit;
        //   rb.velocity = new Vector2(hor * speed, ver * speed);
    }

}
