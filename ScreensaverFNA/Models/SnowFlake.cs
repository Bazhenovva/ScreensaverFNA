namespace ScreensaverFNA.Models
{
    /// <summary>
    /// Представляет одну снежинку в анимации
    /// </summary>
    internal struct SnowFlake
    {
        /// <summary>
        /// Горизонтальная координата
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Вертикальная координата
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Скорость падения
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// Масштаб относительно исходного изображения
        /// </summary>
        public float Scale { get; set; }
    }
}
