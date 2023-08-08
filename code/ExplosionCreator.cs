using Sandbox.Tools;

namespace Sandbox.MoskalykA
{
	[Library( "tool_explosioncreator", Title = "Explosion creator", Description = "Left click: Creates an explosion", Group = "fun" )]
	public class ExplosionCreator : BaseTool
	{
		public override void Simulate()
		{
			if ( !Game.IsServer )
				return;

			if (Input.Pressed( "attack1" ))
			{
				var tr = DoTrace();

				if ( !tr.Hit )
					return;

				var explosion = new ExplosionEntity
				{
					Position = tr.EndPosition
				};
				explosion.Explode( explosion );
			}
		}
	}
}
