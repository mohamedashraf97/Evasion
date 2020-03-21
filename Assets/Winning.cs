using UnityEngine;
public class Winning : MonoBehaviour {

public GameManagement GameManagement;
public MeshRenderer mesh ;


void OnCollisionEnter(Collision other)
{
	mesh.enabled = false ;
	GameManagement.Complete();
}

	
}
