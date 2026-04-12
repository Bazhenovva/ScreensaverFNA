using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ScreensaverFNA.Constants;
using ScreensaverFNA.Models;

namespace ScreensaverFNA
{
    /// <summary>
    /// снегопад — отображает падающие снежинки
    /// </summary>
    internal class SnowfallGame : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private Texture2D snowflakeTexture;
        private Texture2D backgroundTexture;

        private SnowFlake[] snowflakes;
        private Random rand = new Random();

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="SnowfallGame"/>
        /// </summary>
        public SnowfallGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            graphics.IsFullScreen = true;

            IsMouseVisible = false;
            Window.AllowUserResizing = false;
        }

        /// <summary>
        /// Инициализация игры перед загрузкой контента
        /// </summary>
        protected override void Initialize()
        {
            snowflakes = new SnowFlake[SnowflakeConstants.CountSnowFlakes];

            base.Initialize();
        }

        /// <summary>
        /// Загрузка контента
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            backgroundTexture = Content.Load<Texture2D>("background");
            snowflakeTexture = Content.Load<Texture2D>("snowflake");

            ResetAllSnowflakes();
        }

        /// <summary>
        /// Обновление состояния игры — движение снежинок
        /// </summary>
        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().GetPressedKeys().Length > 0)
            {
                Exit();
            }

            for (var i = 0; i < snowflakes.Length; i++)
            {
                snowflakes[i].Y += snowflakes[i].Speed;

                if (snowflakes[i].Y > GraphicsDevice.Viewport.Height)
                {
                    ResetSnowFlake(i);
                }
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// Отрисовка кадра — фон и снежинки
        /// </summary>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();

            spriteBatch.Draw(
                backgroundTexture,
                new Rectangle(
                    GameConstants.OriginX,
                    GameConstants.OriginY,
                    GraphicsDevice.Viewport.Width,
                    GraphicsDevice.Viewport.Height
                ),
                Color.White
            );

            foreach (var flake in snowflakes)
            {
                var drawWidth = (int)(snowflakeTexture.Width * flake.Scale);
                var drawHeight = (int)(snowflakeTexture.Height * flake.Scale);

                spriteBatch.Draw(
                    snowflakeTexture,
                    new Rectangle(flake.X, flake.Y, drawWidth, drawHeight),
                    Color.White
                );
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// Сброс всех снежинок на начальные позиции
        /// </summary>
        private void ResetAllSnowflakes()
        {
            for (var i = 0; i < snowflakes.Length; i++)
            {
                ResetSnowFlake(i);
            }
        }

        /// <summary>
        /// Сброс одной снежинки на случайную позицию
        /// </summary>
        private void ResetSnowFlake(int index)
        {
            var randomSize = rand.Next(SnowflakeConstants.MinRandSize, SnowflakeConstants.MaxRandSize);

            var speed = randomSize <= SnowflakeConstants.MediumRandSize ?
                SnowflakeConstants.MinSpeed : SnowflakeConstants.MaxSpeed;

            var scale = (float)randomSize / snowflakeTexture.Width;

            snowflakes[index].X = rand.Next(GraphicsDevice.Viewport.Width);
            snowflakes[index].Y = rand.Next(-GraphicsDevice.Viewport.Height, SnowflakeConstants.SpawnTopY);
            snowflakes[index].Speed = speed;
            snowflakes[index].Scale = scale;
        }
    }
}
