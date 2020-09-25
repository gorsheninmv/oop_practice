using System;

namespace OopPractice.ExternalServices
{
  /// <summary>
  /// Заглушка сервиса шифрования.
  /// </summary>
  internal sealed class EncryptingService
  {
    /// <summary>
    /// Зашифровать файлы в директории.
    /// </summary>
    /// <param name="directoryFullPath">Полный путь директории.</param>
    public void Encrypt(string directoryFullPath)
    {
      Console.WriteLine($"Файлы в директории {directoryFullPath} зашифрованы.");
    }
  }
}
