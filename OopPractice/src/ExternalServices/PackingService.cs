using System;

namespace OopPractice.ExternalServices
{
  /// <summary>
  /// Заглушка сервиса архивирования.
  /// </summary>
  internal sealed class PackingService
  {
    /// <summary>
    /// Запаковать файлы.
    /// </summary>
    /// <param name="directoryFullPath">Полный путь директории, где лежат файлы.</param>
    /// <param name="archiveName">Имя результирующего архива.</param>
    public void Pack(string directoryFullPath, string archiveName)
    {
      Console.WriteLine($"Файлы в директории {directoryFullPath} упакованы в архив с именем \"{archiveName}\".");
    }
  }
}
