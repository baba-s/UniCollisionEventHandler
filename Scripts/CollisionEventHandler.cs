using System;
using UnityEngine;

namespace Kogane
{
	public sealed class CollisionEventHandler : MonoBehaviour
	{
		public Action<Collision>   onCollisionEnter   { get; set; }
		public Action<Collision2D> onCollisionEnter2D { get; set; }
		public Action<Collision>   onCollisionExit    { get; set; }
		public Action<Collision2D> onCollisionExit2D  { get; set; }
		public Action<Collision>   onCollisionStay    { get; set; }
		public Action<Collision2D> onCollisionStay2D  { get; set; }
		public Action<Collider>    onTriggerEnter     { get; set; }
		public Action<Collider2D>  onTriggerEnter2D   { get; set; }
		public Action<Collider>    onTriggerExit      { get; set; }
		public Action<Collider2D>  onTriggerExit2D    { get; set; }
		public Action<Collider>    onTriggerStay      { get; set; }
		public Action<Collider2D>  onTriggerStay2D    { get; set; }

		private void OnCollisionEnter( Collision other )
		{
			onCollisionEnter?.Invoke( other );
		}

		private void OnCollisionEnter2D( Collision2D other )
		{
			onCollisionEnter2D?.Invoke( other );
		}

		private void OnCollisionExit( Collision other )
		{
			onCollisionExit?.Invoke( other );
		}

		private void OnCollisionExit2D( Collision2D other )
		{
			onCollisionExit2D?.Invoke( other );
		}

		private void OnCollisionStay( Collision other )
		{
			onCollisionStay?.Invoke( other );
		}

		private void OnCollisionStay2D( Collision2D other )
		{
			onCollisionStay2D?.Invoke( other );
		}

		private void OnTriggerEnter( Collider other )
		{
			onTriggerEnter?.Invoke( other );
		}

		private void OnTriggerEnter2D( Collider2D other )
		{
			onTriggerEnter2D?.Invoke( other );
		}

		private void OnTriggerExit( Collider other )
		{
			onTriggerExit?.Invoke( other );
		}

		private void OnTriggerExit2D( Collider2D other )
		{
			onTriggerExit2D?.Invoke( other );
		}

		private void OnTriggerStay( Collider other )
		{
			onTriggerStay?.Invoke( other );
		}

		private void OnTriggerStay2D( Collider2D other )
		{
			onTriggerStay2D?.Invoke( other );
		}
	}
}