namespace OopPractice
{
  /// <summary>
  /// ID-генератор. Непотокобезопасный.
  /// </summary>
  /// <remarks>Реализует паттерн Singleton.</remarks>
  internal sealed class IdGenerator
  {
    #region Поля и свойства

    /// <summary>
    /// Инстанс одиночки.
    /// </summary>
    public static IdGenerator Instance { get; } = new IdGenerator();

    /// <summary>
    /// Свободный ID.
    /// </summary>
    private static uint nextId = 1;

    #endregion

    #region Методы

    /// <summary>
    /// Получить ID.
    /// </summary>
    /// <returns>ID.</returns>
    public uint GetId()
    {
      return nextId++;
    }

    #endregion
  }
}
