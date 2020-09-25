using System.Collections.Generic;

namespace OopPractice.Document
{
  /// <summary>
  /// Интерфейс комплекта документов.
  /// </summary>
  internal interface IDocumentComposite : IDocumentComponent
  {
    /// <summary>
    /// Добавить документ в комплект.
    /// </summary>
    /// <param name="doc">Документ.</param>
    void Add(IDocumentComponent doc);

    /// <summary>
    /// Добавить документы в комплект.
    /// </summary>
    /// <param name="docs">Документы.</param>
    void Add(IEnumerable<IDocumentComponent> docs);
  }
}
