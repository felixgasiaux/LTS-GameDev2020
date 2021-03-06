﻿using UnityEngine;
using System.Collections;


namespace Pathfinding
{
	/// <summary>
	/// Sets the destination of an AI to the position of a specified object.
	/// This component should be attached to a GameObject together with a movement script such as AIPath, RichAI or AILerp.
	/// This component will then make the AI move towards the <see cref="target"/> set on this component.
	///
	/// See: <see cref="Pathfinding.IAstarAI.destination"/>
	///
	/// [Open online documentation to see images]
	/// </summary>
	[UniqueComponent(tag = "ai.destination")]
	[HelpURL("http://arongranberg.com/astar/docs/class_pathfinding_1_1_a_i_destination_setter.php")]
	public class ennemies_controller : VersionedMonoBehaviour
	{
		/// <summary>The object that the AI should move to</summary>
		public Transform target;
		public Animator animator;
		public bool explode = false;
		public Collider2D m_ObjectCollider;
		public AudioSource audioData;
		IAstarAI ai;
		/*
		void OnEnable () {
			ai = GetComponent<IAstarAI>();
			// Update the destination right before searching for a path as well.
			// This is enough in theory, but this script will also update the destination every
			// frame as the destination is used for debugging and may be used for other things by other
			// scripts as well. So it makes sense that it is up to date every frame.
			if (ai != null) ai.onSearchPath += Update;
		}
		*/
		void Start()
		{
			m_ObjectCollider.isTrigger = false;
		}
		void OnDisable()
		{
			if (ai != null) ai.onSearchPath -= Update;
		}

		/// <summary>Updates the AI's destination every frame</summary>
		void Update()
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
			if (explode == false)
			{
				if (target != null && ai != null) ai.destination = target.position;
			}
            else
			{
				if (target != null && ai != null) ai.destination = ai.position;
			}
			if (Input.GetMouseButtonDown(0))
			{
				if (hit.collider == m_ObjectCollider)
				{
					explode = true;
					animator.SetBool("explode", explode);
					Debug.Log("explose");
					m_ObjectCollider.isTrigger = true;
				}
			}
		}
		private void OnTriggerEnter2D(Collider2D collision)
		{
			Debug.Log("trigger : "+collision.gameObject.name);
			ai = GetComponent<IAstarAI>();
			if (ai != null) ai.onSearchPath += Update;
		}
		void OnCollisionEnter2D(Collision2D col)
		{

			Debug.Log("collsion : " + col.gameObject.name);
			if (col.gameObject.name == "player" )
			{
				audioData.Play(0);
				explode = true;
				animator.SetBool("explode", explode);
				Debug.Log("explose");
				m_ObjectCollider.isTrigger = true;
			}
		}
	}
}
