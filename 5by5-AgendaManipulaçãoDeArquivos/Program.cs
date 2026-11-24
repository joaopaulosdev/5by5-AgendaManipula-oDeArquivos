var path = @"C:\Users\JoãoPaulo\source\repos\5by5-ManipulaçãoDeArquivos\5by5-AgendaManipulaçãoDeArquivos";
var file = "Agenda.txt";

var agenda = new List<Pessoa>();


bool PathValidation(string p)
{
    try
    {
        Directory.CreateDirectory(p);
        return true;
    }
    catch (DirectoryNotFoundException e)
    {
        Console.WriteLine(e.Message);
        return false;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return false;
    }

}

bool FileValidation(string p)
{
    if (File.Exists(p + file))
        return true;
    try
    {
        if (PathValidation(p))
        {
            File.Create(p + file).Close();
            return true;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return false;
    }
    return false;
}

void CreateAgenda(List<Pessoa> a)
{
    var writer = new StreamWriter(path + file);

    Pessoa p1 = new Pessoa("Felipe", "16 933009977", 'M');
    Pessoa p2 = new Pessoa("Joao", "16 933006541", 'M');
    Pessoa p3 = new Pessoa("Matheus", "16 933009876", 'M');
    Pessoa p4 = new Pessoa("Pestana", "16 933003459", 'M');

    agenda.Add(p1);
    agenda.Add(p2);
    agenda.Add(p3);
    agenda.Add(p4);

    if (FileValidation(path))
    {
        foreach (var item in agenda)
        {
            writer.WriteLine("Nome: " + item.Nome + " | Contato: " + item.Contato);
        }
    }

    writer.Close();
}
void ShowAgenda()
{
    var reader = new StreamReader(path + file);

    Console.WriteLine(reader.ReadToEnd());

    reader.Close();
}

CreateAgenda(agenda);
ShowAgenda();

