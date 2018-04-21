using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Follow smoothed Speed rate (greate = faster)
	public float smoothSpeed = 0.125f;

	// Object targeted by the camera  
	// (remember that it created a var on camera inspector, drag&drop the char on it) 
	public Transform targetCharacter;

	// The camera got the char feet position, so create an offset to fix it
	// (it will create the offset var on inspector)
	public Vector3 offset;

	// It might update it position on Target move
	void LateUpdate() {
		// Update it camera position with the target position
		transform.position = targetCharacter.position + offset;
	}


}
