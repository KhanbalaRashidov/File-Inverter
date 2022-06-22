using System.Net.Http.Headers;
using System.IO;

string[] lines= File.ReadAllLines("C:\\Users\\KhanbalaRashidov\\Desktop\\input.txt");
string path = "C:\\Users\\KhanbalaRashidov\\Desktop\\output.txt";
FileStream f = new FileStream(path, FileMode.OpenOrCreate);
StreamWriter s = new StreamWriter(f);
if (lines.Length >= 10)
{
    foreach (var item in lines)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://localhost:44315/api/inverter/");
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("apllication/json"));
        HttpResponseMessage response = await client.GetAsync($"{item}");
        var data = await response.Content.ReadAsStringAsync();
        Console.WriteLine(await response.Content.ReadAsStringAsync());

        s.WriteLine(data);
    }
}
s.Close();
f.Close();

//HttpClient client = new HttpClient();
//client.BaseAddress = new Uri("https://localhost:44315/api/inverter/");
//client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("apllication/json"));
//HttpResponseMessage response = await client.GetAsync("line");

//Console.WriteLine( await response.Content.ReadAsStringAsync());
Console.ReadLine();

