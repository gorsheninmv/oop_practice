using System.Collections.Generic;

namespace OopPractice.Document
{
  /// <summary>
  /// Интерфейс документа или комплекта документов.
  /// </summary>
  internal interface IDocumentComponent
  {
    /// <summary>
    /// ID.
    /// </summary>
    uint Id { get; }

    /// <summary>
    /// Имя.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Описание.
    /// </summary>
    string Description { get; }

    /// <summary>
    /// Получить имена документов.
    /// </summary>
    /// <returns>Список файлов.</returns>
    IEnumerable<string> GetFileNames();

    /// <summary>
    /// Найти документ или комплект документов.
    /// </summary>
    /// <param name="name">Имя документа/комплекта.</param>
    /// <returns>Документ/комплект. Если не найден, то null.</returns>
    IDocumentComponent? TryFind(string name);
  }
}
