 var cameraTarget : GameObject;
 var smoothTime : float = 0.1;
 var cameraFollowX : boolean = true;
 var cameraFollowY : boolean = true;
 var velocity : Vector2;

 private var thisTransform : Transform;
 
 function Start ()
 {

 }
 
 function Update () 
 {
 if (cameraFollowX)
 {
transform.position.x = Mathf.SmoothDamp (transform.position.x, cameraTarget.transform.position.x, velocity.x, smoothTime);
 }
 if (cameraFollowY)
 {
 transform.position.y = Mathf.SmoothDamp (transform.position.y, cameraTarget.transform.position.y, velocity.y, smoothTime);
 }
	

 }