using System.Collections.Generic;

namespace OopPractice.Document
{
  /// <summary>
  /// Документ.
  /// </summary>
  internal class DocumentComponent : IDocumentComponent
  {
    #region Методы

    /// <summary>
    /// Создать описание документа.
    /// </summary>
    /// <returns>Описание документа.</returns>
    protected virtual string MakeDescription()
    {
      return this.Name;
    }

    #endregion

    #region IDocumentComponent

    public uint Id { get; }

    public string Name { get; set; }

    public string Description => this.MakeDescription();

    public virtual IEnumerable<string> GetFileNames()
    {
      yield return this.Name;
    }

    public virtual IDocumentComponent TryFind(string name)
    {
      return this.Name.Equals(name) ? this : null;
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="name">Имя документа.</param>
    public DocumentComponent(string name)
    {
      this.Name = name;
      this.Id = IdGenerator.Instance.GetId();
    }

    #endregion
  }
}
