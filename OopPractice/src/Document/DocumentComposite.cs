using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OopPractice.Document
{
  /// <summary>
  /// Комплект документов.
  /// </summary>
  internal sealed class DocumentComposite : DocumentComponent, IDocumentComposite
  {
    #region Поля и свойства

    /// <summary>
    /// Документы / комплекты документов.
    /// </summary>
    private readonly List<IDocumentComponent> docs;

    #endregion

    #region IDocumentComposite

    public void Add(IDocumentComponent doc)
    {
      this.docs.Add(doc);
    }

    public void Add(IEnumerable<IDocumentComponent> docs)
    {
      this.docs.AddRange(docs);
    }

    #endregion

    #region Базовый класс

    protected override string MakeDescription()
    {
      var sb = new StringBuilder();
      sb.Append($"{this.Name} (id: {this.Id})");

      foreach (var doc in this.docs)
      {
        sb.Append(Environment.NewLine);
        sb.Append(doc.Description);
      }

      sb.Replace(Environment.NewLine, Environment.NewLine + '\t');

      return sb.ToString();
    }

    public override IEnumerable<string> GetFileNames()
    {
      return this.docs.SelectMany(doc => doc.GetFileNames());
    }

    public override IDocumentComponent? TryFind(string name)
    {
      foreach (var doc in this.docs)
      {
        var found = doc.TryFind(name);

        if (found != null)
          return found;
      }

      return null;
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="name">Имя комплекта.</param>
    public DocumentComposite(string name) : base(name)
    {
      this.docs = new List<IDocumentComponent>();
    }

    #endregion
  }
}
