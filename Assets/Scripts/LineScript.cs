using UnityEngine;
using System.Collections;

public class LineScript : MonoBehaviour {

	public Vector2 A;
	public Vector2 B;
	public float Thickness;
	public Sprite HalfCircle, LightningSegment;
	
	public LineScript() { }
	public LineScript(Vector2 a, Vector2 b, float thickness = 1)
	{
		A = a;
		B = b;
		Thickness = thickness;
	}

	/*public void Draw(SpriteBatch spriteBatch, Color color)
	{
		Vector2 tangent = B - A;
		float rotation = (float)Mathf.Atan2(tangent.y, tangent.x);
		
		const float ImageThickness = 8;
		float thicknessScale = Thickness / ImageThickness;

		Vector2 capOrigin = new Vector2(HalfCircle.bounds.size.x, HalfCircle.bounds.size.y / 2f);
		Vector2 middleOrigin = new Vector2(0, LightningSegment.bounds.size.y / 2f);
		Vector2 middleScale = new Vector2(tangent.magnitude, thicknessScale);
		
		spriteBatch.Draw(LightningSegment, A, null, color, rotation, middleOrigin, middleScale, SpriteEffects.None, 0f);
		spriteBatch.Draw(HalfCircle, A, null, color, rotation, capOrigin, thicknessScale, SpriteEffects.None, 0f);
		spriteBatch.Draw(HalfCircle, B, null, color, rotation + Mathf.PI, capOrigin, thicknessScale, SpriteEffects.None, 0f);
	}*/
}
