using OopPractice.Document;
using OopPractice.ExternalServices;

namespace OopPractice.DocumentExporter
{
  /// <summary>
  /// Декоратор архивирования.
  /// </summary>
  internal sealed class PackingDecorator : DecoratorBase
  {
    #region Базовый класс

    public override void Export(IDocumentComponent docs, string destDirFullPath)
    {
      this.exporter.Export(docs, destDirFullPath);

      var packingService = new PackingService();
      packingService.Pack(destDirFullPath, docs.Name);
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструтор.
    /// </summary>
    /// <param name="exporter">Объект, поддреживающий экспорт документов.</param>
    public PackingDecorator(IExporter exporter) : base(exporter) { }

    #endregion
  }
}
