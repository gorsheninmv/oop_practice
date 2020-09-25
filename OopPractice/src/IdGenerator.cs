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
    public static IdGenerator Instance { get; }

    /// <summary>
    /// Свободный ID.
    /// </summary>
    private static uint unassignedId;

    #endregion

    #region Методы

    /// <summary>
    /// Получить ID.
    /// </summary>
    /// <returns>ID.</returns>
    public uint GetId()
    {
      uint ret = unassignedId;
      ++unassignedId;

      return ret;
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструтор.
    /// </summary>
    static IdGenerator()
    {
      Instance = new IdGenerator();
      unassignedId = 0;
    }

    #endregion
  }
}
