using OopPractice.Document;

namespace OopPractice.DocumentExporter
{
  /// <summary>
  /// Базовый декратор.
  /// </summary>
  internal abstract class DecoratorBase : IExporter
  {
    #region Поля и свойства

    /// <summary>
    /// Декорируемый объект.
    /// </summary>
    protected readonly IExporter exporter;

    #endregion

    #region IExporter

    public abstract void Export(IDocumentComponent docs, string destDirFullPath);

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="exporter">Декорируемый объект.</param>
    protected DecoratorBase(IExporter exporter)
    {
      this.exporter = exporter;
    }

    #endregion
  }
}
