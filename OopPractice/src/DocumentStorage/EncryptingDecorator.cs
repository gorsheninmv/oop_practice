using OopPractice.Document;
using OopPractice.ExternalServices;

namespace OopPractice.DocumentStorage
{
  /// <summary>
  /// Декоратор шифрования.
  /// </summary>
  internal sealed class EncryptingDecorator : DecoratorBase
  {
    #region Базовый класс

    public override void Save(IDocumentComponent docs, string destDirFullPath)
    {
      this.storage.Save(docs, destDirFullPath);

      var encryptingService = new EncryptingService();
      encryptingService.Encrypt(destDirFullPath);
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструтор.
    /// </summary>
    /// <param name="storage">Объект, поддреживающий экспорт документов.</param>
    public EncryptingDecorator(IFileSystemStorage storage) : base(storage) { }

    #endregion
  }
}
