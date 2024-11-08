using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Topic_2___Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D circleTexture, rectTexture;
        Rectangle circleRect, rectRect;
        SpriteFont textFont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();

            circleRect = new Rectangle(150, 100, 100, 100);
            rectRect = new Rectangle(200, 150, 300, 300);
            textFont = Content.Load<SpriteFont>("TextFont");

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            circleTexture = Content.Load<Texture2D>("circle");
            rectTexture = Content.Load<Texture2D>("rectangle");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(rectTexture, rectRect, Color.Yellow);
            _spriteBatch.Draw(circleTexture, circleRect, Color.White);
            _spriteBatch.Draw(circleTexture, new Rectangle(250, 250, 50, 50), Color.White);
            _spriteBatch.Draw(circleTexture, new Rectangle(350, 300, 80, 80), Color.White);
            _spriteBatch.Draw(circleTexture, new Rectangle(400, 200, 50, 50), Color.White);
            _spriteBatch.Draw(rectTexture, new Rectangle(265, 400, 170, 40), Color.Black);
            _spriteBatch.DrawString(textFont, "CHEESE", new Vector2(270, 400), Color.Yellow);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
