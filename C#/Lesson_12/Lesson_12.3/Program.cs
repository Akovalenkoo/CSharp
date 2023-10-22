using System;

class DocumentWorker
{
    public void OpenDocument()
    {
        Console.WriteLine("Документ відкритий");
    }

    public void EditDocument()
    {
        Console.WriteLine("Редагування документа доступне у версії Про");
    }

    public void SaveDocument()
    {
        Console.WriteLine("Збереження документа доступне у версії Про");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public new void EditDocument()
    {
        Console.WriteLine("Документ відредаговано");
    }

    public new void SaveDocument()
    {
        Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт");
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public new void SaveDocument()
    {
        Console.WriteLine("Документ збережено у новому форматі");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть ключ доступу (pro/exp):");
        string key = Console.ReadLine();

        DocumentWorker document;

        if (key == "pro")
        {
            document = new ProDocumentWorker();
        }
        else if (key == "exp")
        {
            document = new ExpertDocumentWorker();
        }
        else
        {
            document = new DocumentWorker();
        }

        document.OpenDocument();
        document.EditDocument();
        document.SaveDocument();
        Console.ReadKey();
    }
}
;
