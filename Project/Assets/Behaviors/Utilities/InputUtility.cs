using UnityEngine;

public static class InputUtility
{

	public static class Direction
	{
		public const string X = "Mouse X";
		public const string Y = "Mouse Y";
		public const string Z = "Mouse ScrollWheel";

		public static Vector3 GetVector()
		{
			return new Vector3(
				Input.GetAxis(X),
				Input.GetAxis(Y),
				Input.GetAxis(Z));
		}

		public static Vector3 GetVector(Vector3 multiplier)
		{
			return new Vector3(
				Input.GetAxis(X) * multiplier.x,
				Input.GetAxis(Y) * multiplier.y,
				Input.GetAxis(Z) * multiplier.z);
		}
	}

	public static class Movement
	{
		public enum Type {
			Slide,
			Turn
		}

		public const string HORIZONTAL = "Horizontal";
		public const string VERTICAL = "Vertical";


		public static Vector2 GetVector()
		{
			return new Vector2(
				Input.GetAxis(HORIZONTAL),
				Input.GetAxis(VERTICAL));
		}

		public static Vector2 GetVector(Vector2 multiplier)
		{
			return new Vector2(
				Input.GetAxis(HORIZONTAL) * multiplier.x,
				Input.GetAxis(VERTICAL) * multiplier.y);
		}

		public static Vector2 GetVector(Vector3 multiplier)
		{
			return new Vector2(
				Input.GetAxis(HORIZONTAL) * multiplier.x,
				Input.GetAxis(VERTICAL) * multiplier.y);
		}
	}

}