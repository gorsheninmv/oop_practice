﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OopPractice.Document
{
  /// <summary>
  /// Комплект документов.
  /// </summary>
  internal sealed class DocumentComposite : DocumentComponent
  {
    #region Поля и свойства

    /// <summary>
    /// Документы / комплекты документов.
    /// </summary>
    private readonly List<IDocumentComponent> documents = new List<IDocumentComponent>();

    #endregion

    #region IDocumentComposite

    public void Add(IDocumentComponent doc)
    {
      this.documents.Add(doc);
    }

    public void Add(IEnumerable<IDocumentComponent> docs)
    {
      this.documents.AddRange(docs);
    }

    #endregion

    #region Базовый класс

    public override IEnumerable<IDocumentComponent> Children => this.documents;

    public override IEnumerable<string> GetFileNames()
    {
      return this.documents.SelectMany(doc => doc.GetFileNames());
    }

    protected override string CreateDescription()
    {
      var sb = new StringBuilder();
      sb.Append($"{this.Name} (id: {this.Id})");

      foreach (var doc in this.documents)
      {
        sb.Append(Environment.NewLine);
        sb.Append(doc.Description);
      }

      sb.Replace(Environment.NewLine, Environment.NewLine + '\t');

      return sb.ToString();
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="name">Имя комплекта.</param>
    /// <param name="id">Id комплекта.</param>
    public DocumentComposite(string name, uint id) : base(name, id) { }

    #endregion
  }
}
