using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Screens;
using MonoGame.Extended.Screens.Transitions;

namespace SAE
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteFont _font;
        private readonly ScreenManager _screenManager;
        public SpriteBatch SpriteBatch { get; set; }
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _screenManager = new ScreenManager();
            Components.Add(_screenManager);
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            

            // TODO: use this.Content to load your game content here
            SpriteBatch = new SpriteBatch(GraphicsDevice);
            _font = Content.Load<SpriteFont>("Font");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Enter))
            {
                LoadScreen1();
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            SpriteBatch.Begin();
            SpriteBatch.DrawString(_font, "Press enter to start a new game", new Vector2(300, 200), Color.White);
            SpriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        private void LoadScreen1()
        {
            _screenManager.LoadScreen(new Lobby(this), new FadeTransition(GraphicsDevice, Color.Black));
        }
    }
}
