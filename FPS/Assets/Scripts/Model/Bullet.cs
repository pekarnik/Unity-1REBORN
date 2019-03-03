namespace FPS
{
	public class Bullet:Ammunition
	{
		private void OnCollisionEnter(UnityEngine.Collision collision)
		{
			var tempObj = collision.gameObject.GetComponent<ISetDamage>();
			int criticalDamage=UnityEngine.Random.Range(2,5);
			tempObj?.SetDamage(new InfoCollision(_curDamage*UnityEngine.Random.Range(0,3)>UnityEngine.Random.Range(0,100)?criticalDamage:1, Rigidbody.velocity));
			Destroy(gameObject);
		}
	}
}
