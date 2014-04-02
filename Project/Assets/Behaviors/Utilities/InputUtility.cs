using UnityEngine;

public static class InputUtility
{

	public static class Movement
	{
		public enum Type {
			Slide,
			Turn
		}

		public const string HORIZONTAL = "Horizontal";
		public const string VERTICAL = "Vertical";


		public static Vector2 GetAxisVector()
		{
			return new Vector2(
				Input.GetAxis(HORIZONTAL),
				Input.GetAxis(VERTICAL));
		}

		public static Vector2 GetAxisVector(Vector2 multiplier)
		{
			return new Vector2(
				Input.GetAxis(HORIZONTAL) * multiplier.x,
				Input.GetAxis(VERTICAL) * multiplier.y);
		}
	}
}