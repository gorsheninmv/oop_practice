using OopPractice.Document;
using OopPractice.ExternalServices;

namespace OopPractice.DocumentExporter
{
  /// <summary>
  /// Декоратор шифрования.
  /// </summary>
  internal sealed class EncryptingDecorator : DecoratorBase
  {
    #region Базовый класс

    public override void Export(IDocumentComponent docs, string destDirFullPath)
    {
      this.exporter.Export(docs, destDirFullPath);

      var encryptingService = new EncryptingService();
      encryptingService.Encrypt(destDirFullPath);
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструтор.
    /// </summary>
    /// <param name="expoter">Объект, поддреживающий экспорт документов.</param>
    public EncryptingDecorator(IExporter exporter) : base(exporter) { }

    #endregion
  }
}
