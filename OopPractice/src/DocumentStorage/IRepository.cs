using OopPractice.Document;

namespace OopPractice.DocumentStorage
{
  /// <summary>
  /// Репозиторий документов.
  /// </summary>
  internal interface IRepository
  {
    /// <summary>
    /// Загрузить документ/комплект.
    /// </summary>
    /// <returns>Документ/комплект.</returns>
    IDocumentComponent Load();
  }
}
