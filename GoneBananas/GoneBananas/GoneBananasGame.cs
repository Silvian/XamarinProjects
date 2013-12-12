using System;
using Microsoft.Xna.Framework;
using Cocos2D;

namespace GoneBananas
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class GoneBananasGame : Game
    {
        readonly GraphicsDeviceManager graphics;

        public GoneBananasGame()
        {
            graphics = new GraphicsDeviceManager(this);

			Content.RootDirectory = "Content";
            graphics.IsFullScreen = false;

            CCApplication application = new GoneBananasApplication(this, graphics);
            Components.Add(application);
        }
    }
}