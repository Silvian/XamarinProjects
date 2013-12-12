using System;
using System.Collections.Generic;
using Cocos2D;
using CocosDenshion;
using XNA = Microsoft.Xna.Framework;

namespace GoneBananas
{
	public class GameLayer : CCLayerColor
	{
		const float MONKEY_SPEED = 500.0f;
		float dt = 0;
		CCSprite monkey;
		List<CCSprite> visibleBananas;
		List<CCSprite> hitBananas;

		public GameLayer ()
		{
			TouchEnabled = true;
			Color = new CCColor3B (XNA.Color.White);
			Opacity = 255;

			visibleBananas = new List<CCSprite> ();
			hitBananas = new List<CCSprite> ();
	
			monkey = new CCSprite ("Monkey");
			monkey.Position = CCDirector.SharedDirector.WinSize.Center;
			AddChild (monkey);

			Schedule ((t) => {
				visibleBananas.Add (AddBanana ());
				dt += t;
				if(ShouldEndGame ()){
					dt = 0;
					var gameOverScene = GameOverLayer.SceneWithScore(hitBananas.Count);
					CCDirector.SharedDirector.ReplaceScene (gameOverScene);
				}
			}, 1.0f);

			Schedule ((t) => {
				CheckCollision ();
			});
		}

		CCSprite AddBanana ()
		{
			var banana = new CCSprite ("Banana");

			double rnd = new Random ().NextDouble ();
			double randomX = (rnd > 0) 
				? rnd * CCDirector.SharedDirector.WinSize.Width - banana.ContentSize.Width / 2 
				: banana.ContentSize.Width / 2;
	
			banana.Position = new CCPoint ((float)randomX, CCDirector.SharedDirector.WinSize.Height - banana.ContentSize.Height / 2);

			AddChild (banana);

			var moveBanana = new CCMoveTo (5.0f, new CCPoint (banana.Position.X, 0));

			var moveBananaComplete = new CCCallFuncN ((node) => {
				node.RemoveFromParentAndCleanup (true);
			});

			var moveBananaSequence = new CCSequence (moveBanana, moveBananaComplete);

			banana.RunAction (moveBananaSequence);

			return banana;
		}

		void CheckCollision ()
		{
			visibleBananas.ForEach ((banana) => {
				bool hit = banana.BoundingBox.IntersectsRect (monkey.BoundingBox);
				if (hit) {
					hitBananas.Add (banana);
					banana.RemoveFromParent ();
				}
			});

			hitBananas.ForEach ((banana) => {
				visibleBananas.Remove (banana); });
		}

		bool ShouldEndGame()
		{
			return dt > 20.0;
		}

		public override void TouchesEnded (List<CCTouch> touches)
		{
			base.TouchesEnded (touches);

			var location = touches [0].Location;

			float ds = CCPoint.Distance (monkey.Position, location);

			float dt = ds / MONKEY_SPEED;

			var moveMonkey = new CCMoveTo (dt, location);
			monkey.RunAction (moveMonkey);	

			CCSimpleAudioEngine.SharedEngine.PlayEffect ("Sounds/tap.mp3");
		}

		public static CCScene Scene {
			get {
				var scene = new CCScene ();
				var layer = new GameLayer ();
			
				scene.AddChild (layer);

				return scene;
			}
		}
	}
}

