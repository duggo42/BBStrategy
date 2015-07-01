using UnityEngine;
using System.Collections;

public class Player {
	[System.Flags]
	public enum Position {
		PG = 1,
		SG = 2,
		SF = 4,
		PF = 8,
		C = 16
	}

	public int playerID;

	public Position position;

	public int uniformNumber;

	public int offenseRating;
	public int defenseRating;
	public int reboundRating;
	public int ballHandlingRating;
	public int freeThrowRating;

}
