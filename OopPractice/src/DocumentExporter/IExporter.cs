using OopPractice.Document;

namespace OopPractice.DocumentExporter
{
  /// <summary>
  /// Экспортер документов.
  /// </summary>
  internal interface IExporter
  {
    /// <summary>
    /// Экспортировать документ/компонент.
    /// </summary>
    /// <param name="document">Документ/компонент.</param>
    /// <param name="destDirFullPath">Полное имя папки для сохранения.</param>
    void Export(IDocumentComponent document, string destDirFullPath);
  }
}
