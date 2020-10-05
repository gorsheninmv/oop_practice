using OopPractice.Document;

namespace OopPractice.DocumentStorage
{
  /// <summary>
  /// Базовый декратор.
  /// </summary>
  internal abstract class DecoratorBase : IFileSystemStorage
  {
    #region Поля и свойства

    /// <summary>
    /// Декорируемый объект.
    /// </summary>
    protected readonly IFileSystemStorage storage;

    #endregion

    #region IFileSystemStorage

    public abstract void Save(IDocumentComponent docs, string destDirFullPath);

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="storage">Декорируемый объект.</param>
    protected DecoratorBase(IFileSystemStorage storage)
    {
      this.storage = storage;
    }

    #endregion
  }
}
