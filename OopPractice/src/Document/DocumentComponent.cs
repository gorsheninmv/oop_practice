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
      return $"{this.Name} (id: {this.Id})";
    }

    #endregion

    #region IDocumentComponent

    public uint Id { get; }

    public string Name { get; set; }

    public string Description => this.MakeDescription();

    public virtual IEnumerable<IDocumentComponent> Children => new IDocumentComponent[0];

    public virtual IEnumerable<string> GetFileNames()
    {
      yield return this.Name;
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="name">Имя документа.</param>
    /// <param name="id">id-документа.</param>
    public DocumentComponent(string name, uint id)
    {
      this.Name = name;
      this.Id = id;
    }

    #endregion
  }
}
