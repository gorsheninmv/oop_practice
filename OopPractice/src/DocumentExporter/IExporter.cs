using OopPractice.Document;

namespace OopPractice.DocumentExporter
{
  /// <summary>
  /// Интерфейс объекта, поддерживающий экспорт документов.
  /// </summary>
  internal interface IExporter
  {
    /// <summary>
    /// Экспортировать документы.
    /// </summary>
    /// <param name="docs">Документ / набор документов.</param>
    /// <param name="destDirFullPath">Полное имя директории для экспорта.</param>
    void Export(IDocumentComponent docs, string destDirFullPath);
  }
}
