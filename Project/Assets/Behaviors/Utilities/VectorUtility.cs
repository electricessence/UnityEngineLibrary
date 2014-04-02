using UnityEngine;

public static class VectorUtility
{
	public static Vector3 SwapYZ(this Vector2 source)
	{
		return new Vector3(source.x,0,source.y);
	}
	public static Vector3 SwapYZ(this Vector3 source)
	{
		return new Vector3(source.x,source.z,source.y);
	}

	public static Vector3 Forward3(this Vector2 source)
	{
		return new Vector3(0,0,source.y);
	}

	public static Vector3 Forward(this Vector3 source)
	{
		return new Vector3(0,0,source.y);
	}

	public static Vector3 Right3(this Vector2 source)
	{
		return new Vector3(source.x,0,0);
	}
	
	public static Vector3 Right(this Vector3 source)
	{
		return new Vector3(source.x,0,0);
	}


}


