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
        internal const int CountSnowFlakes = 1000;

        /// <summary>
        /// Минимальная скорость падения
        /// </summary>
        internal const int MinSpeed = 1;

        /// <summary>
        /// Максимальная скорость падения
        /// </summary>
        internal const int MaxSpeed = 4;

        /// <summary>
        /// Минимальный размер снежинки
        /// </summary>
        internal const int MinRandSize = 20;

        /// <summary>
        /// Максимальный размер снежинки
        /// </summary>
        internal const int MaxRandSize = 50;

        /// <summary>
        /// Средний размер для определения скорости
        /// </summary>
        internal const int MediumRandSize = 30;

        /// <summary>
        /// Нижняя граница начальной позиции (верх экрана)
        /// </summary>
        internal const int SpawnTopY = 0;
    }
}
