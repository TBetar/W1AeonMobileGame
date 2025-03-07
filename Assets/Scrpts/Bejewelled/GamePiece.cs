using UnityEngine;

public class GamePiece : MonoBehaviour, ScreenInteractionController.ITouchable
{
    public void OnTouchBegin(Vector3 touchPositiion)
    {
    }

    public void OnTouchEnd(Vector3 touchPositiion)
    {
    }

    public void OnTouchStay(Vector3 touchPosition)
    {
        //get a world space position based on the touch input
        Vector3 newPosition = ScreenInteractionController.camera.ScreenToWorldPoint(touchPosition);

        //maintain our position
        newPosition.z = transform.position.z;
       
        //apply the new position
        transform.position = newPosition;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
