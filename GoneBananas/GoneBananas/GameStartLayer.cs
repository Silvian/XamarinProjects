using System;
using System.Collections.Generic;
using Cocos2D;
using XNA = Microsoft.Xna.Framework;

namespace GoneBananas
{
	public class GameStartLayer : CCLayerColor
	{
		public GameStartLayer ()
		{
			TouchEnabled = true;

			var label = new CCLabelTTF ("Tap Screen to Go Bananas!", "MarkerFelt", 22) {
				Position = CCDirector.SharedDirector.WinSize.Center,
				Color = new CCColor3B (XNA.Color.Yellow)
			};

			AddChild(label);

			Color = new CCColor3B (XNA.Color.ForestGreen);
			Opacity = 255;
		}
		
		public override void TouchesEnded (List<CCTouch> touches)
		{
			base.TouchesEnded (touches);

			CCDirector.SharedDirector.ReplaceScene (GameLayer.Scene);
		}

		public static CCScene Scene {
			get {
				var scene = new CCScene ();
				var layer = new GameStartLayer ();

				scene.AddChild (layer);

				return scene;
			}
		}
	}
}

