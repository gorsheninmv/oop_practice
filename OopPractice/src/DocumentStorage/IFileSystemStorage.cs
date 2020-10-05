using OopPractice.Document;

namespace OopPractice.DocumentStorage
{
  /// <summary>
  /// Хранилище, использующее в качестве контейнера хранения файловую систему.
  /// </summary>
  internal interface IFileSystemStorage
  {
    /// <summary>
    /// Сохранить документ/компонент.
    /// </summary>
    /// <param name="document">Документ/компонент.</param>
    /// <param name="destDirFullPath">Полное имя папки для сохранения.</param>
    void Save(IDocumentComponent document, string destDirFullPath);
  }
}
