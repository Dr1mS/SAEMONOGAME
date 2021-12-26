using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Screens;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAE
{
    public class Lobby : GameScreen
    {
        private Game1 _myGame; // pour récupérer le jeu en cours
        private SpriteFont _font;
        private SpriteBatch SpriteBatch;
        public Lobby(Game1 game) : base(game)
        {
            _myGame = game;
        }
        public override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);
            _font = Content.Load<SpriteFont>("Font");
            base.LoadContent();
        }
        public override void Update(GameTime gameTime)
        { }
        public override void Draw(GameTime gameTime)
        {
            _myGame.GraphicsDevice.Clear(Color.Red);
            SpriteBatch.Begin();
            SpriteBatch.DrawString(_font, "Scene 1", new Vector2(350, 200), Color.White);
            SpriteBatch.End();
        }
    }
}
