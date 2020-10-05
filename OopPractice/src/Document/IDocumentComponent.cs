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
    /// Дочерние документы.
    /// </summary>
    IEnumerable<IDocumentComponent> Children { get; }

    /// <summary>
    /// Получить имена документов.
    /// </summary>
    /// <returns>Список файлов.</returns>
    IEnumerable<string> GetFileNames();
  }
}
