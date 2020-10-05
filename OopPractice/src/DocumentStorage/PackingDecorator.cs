using OopPractice.Document;
using OopPractice.ExternalServices;

namespace OopPractice.DocumentStorage
{
  /// <summary>
  /// Декоратор архивирования.
  /// </summary>
  internal sealed class PackingDecorator : DecoratorBase
  {
    #region Базовый класс

    public override void Save(IDocumentComponent docs, string destDirFullPath)
    {
      this.storage.Save(docs, destDirFullPath);

      var packingService = new PackingService();
      packingService.Pack(destDirFullPath, docs.Name);
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструтор.
    /// </summary>
    /// <param name="storage">Объект, поддреживающий экспорт документов.</param>
    public PackingDecorator(IFileSystemStorage storage) : base(storage) { }

    #endregion
  }
}
