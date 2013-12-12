using System;
using System.Collections.Generic;
using Cocos2D;
using XNA = Microsoft.Xna.Framework;

namespace GoneBananas
{
	public class GameOverLayer : CCLayerColor
	{
		public GameOverLayer (int score)
		{
			TouchEnabled = true;

			string scoreMessage = String.Format ("Game Over. You collected {0} bananas!", score);

			var scoreLabel = new CCLabelTTF (scoreMessage, "MarkerFelt", 22) {
				Position = new CCPoint( CCDirector.SharedDirector.WinSize.Center.X,  CCDirector.SharedDirector.WinSize.Center.Y + 50),
				Color = new CCColor3B (XNA.Color.Yellow)
			};

			AddChild (scoreLabel);

			var playAgainLabel = new CCLabelTTF ("Tap to Play Again", "MarkerFelt", 22) {
				Position = CCDirector.SharedDirector.WinSize.Center,
				Color = new CCColor3B (XNA.Color.Green)
			};

			AddChild (playAgainLabel);

			Color = new CCColor3B (XNA.Color.Black);
			Opacity = 255;
		}

		public override void TouchesEnded (List<CCTouch> touches)
		{
			base.TouchesEnded (touches);

			CCDirector.SharedDirector.ReplaceScene (GameLayer.Scene);
		}

		public static CCScene SceneWithScore (int score)
		{
			var scene = new CCScene ();
			var layer = new GameOverLayer (score);

			scene.AddChild (layer);

			return scene;
		}
	}
}

