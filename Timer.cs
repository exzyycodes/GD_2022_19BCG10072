using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
	#region Variables

	// timer duration
	float totalSeconds = 0;

	// timer execution
	float elapsedSeconds = 0;
	bool running = false;

	bool started = false;

	#endregion

	#region Properties

	/// Sets the duration of the timer

	public float Duration
	{
		set
		{
			if (!running)
			{
				totalSeconds = value;
			}
		}
	}

	/// Gets whether or not the timer has finished running
	
	public bool Finished
	{
		get { return started && !running; }
	}


	/// Gets whether or not the timer is currently running
	
	public bool Running
	{
		get { return running; }
	}

	#endregion

	#region Methods



	void Update()
	{
		// update timer and checks for finished
		if (running)
		{
			elapsedSeconds += Time.deltaTime;
			if (elapsedSeconds >= totalSeconds)
			{
				running = false;
			}
		}
	}

	/// Runs the timer
	/// the timer only runs if the total seconds > 0
	public void Run()
	{
		// only run with valid duration
		if (totalSeconds > 0)
		{
			started = true;
			running = true;
			elapsedSeconds = 0;
		}
	}

	#endregion
}