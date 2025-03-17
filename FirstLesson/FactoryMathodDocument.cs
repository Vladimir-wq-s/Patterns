using System;

public abstract class Document
{
    public abstract void Print();
}

public class PDFDocument : Document
{
    public override void Print() => Console.WriteLine("Printing PDF document.");
}

public class WordDocument : Document
{
    public override void Print() => Console.WriteLine("Printing Word document.");
}

public class HTMLDocument : Document
{
    public override void Print() => Console.WriteLine("Printing HTML document.");
}

public abstract class DocumentFactory
{
    public abstract Document CreateDocument();
}

public class PDFDocumentFactory : DocumentFactory
{
    public override Document CreateDocument() => new PDFDocument();
}

public class WordDocumentFactory : DocumentFactory
{
    public override Document CreateDocument() => new WordDocument();
}

public class HTMLDocumentFactory : DocumentFactory
{
    public override Document CreateDocument() => new HTMLDocument();
}