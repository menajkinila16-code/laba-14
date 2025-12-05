Console.WriteLine("ВВЕДИТЕ ПУТЬ");//D:\\Лабы Пузыренкова\\text.txt
string inputPuth = Console.ReadLine();
using (StreamReader sr = new StreamReader(inputPuth))
{
    string a = sr.ReadToEnd();

    string nevPuth = "D:\\Лабы Пузыренкова\\Lab- 14\\terrrrr.txt";
    FileInfo file = new FileInfo(nevPuth);
    if (file.Exists)
    {
        using (StreamWriter rss = new StreamWriter(nevPuth))
        {
            rss.WriteLine(a);

        }

    }
    else
    {
        file.Create();
        using (StreamWriter rss = new StreamWriter(nevPuth))
        {
            rss.WriteLine(a);

        }
    }
    using (StringReader ddd = new StringReader(nevPuth))
    {
        string d = ddd.ReadToEnd();
        Console.WriteLine(d);
    }

}