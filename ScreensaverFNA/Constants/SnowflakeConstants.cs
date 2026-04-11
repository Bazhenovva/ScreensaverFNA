namespace ScreensaverFNA.Constants
{
    /// <summary>
    /// Параметры снежинок — количество, скорость и размеры
    /// </summary>
    internal static class SnowflakeConstants
    {
        /// <summary>
        /// Общее количество снежинок на экране
        /// </summary>
        internal const int CountSnowFlakes = 500;

        /// <summary>
        /// Минимальная скорость падения
        /// </summary>
        internal const int MinSpeed = 3;

        /// <summary>
        /// Максимальная скорость падения
        /// </summary>
        internal const int MaxSpeed = 6;

        /// <summary>
        /// Минимальный размер снежинки
        /// </summary>
        internal const int MinRandSize = 20;

        /// <summary>
        /// Максимальный размер снежинки
        /// </summary>
        internal const int MaxRandSize = 51;

        /// <summary>
        /// Средний размер для определения скорости
        /// </summary>
        internal const int MediumRandSize = 35;

        /// <summary>
        /// Верхняя граница появления снежинки
        /// </summary>
        internal const int LessPositionY = -100;

        /// <summary>
        /// Нижняя граница начальной позиции
        /// </summary>
        internal const int MorePositionY = 0;
    }
}
