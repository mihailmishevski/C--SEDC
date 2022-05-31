using SerializeDeserialize.Entities;
using Newtonsoft.Json;

List<Student> students = new List<Student>()
{
    new Student("Mihajlo", "Dimovski", 25),
    new Student("Bojan", "Damcevski", 24),
    new Student("David", "Shumanski", 21)
};

string result = JsonConvert.SerializeObject(students);
string filePath = $@"{Directory.GetCurrentDirectory()}\file.json";
string oneObjectFilePath = $@"{Directory.GetCurrentDirectory()}\oneObject.json";

if (!File.Exists(filePath))
{
    var stream = File.Create(filePath);
    stream.Close();
}

if (!File.Exists(oneObjectFilePath))
{
    var stream = File.Create(oneObjectFilePath);
    stream.Close();
}

using (StreamWriter sw = new StreamWriter(filePath))
{
    sw.WriteLine(result);
    sw.Flush();
}

Student oneObjectStudent = new Student("One", "object", 111111);
string oneObjectJson = JsonConvert.SerializeObject(oneObjectStudent);

using (StreamWriter sw = new StreamWriter(oneObjectFilePath))
{
    sw.Write(oneObjectJson);
    sw.Flush();
}

Console.WriteLine(oneObjectJson + "One object STUDENT");
Console.WriteLine(result);

string json;
using (StreamReader sr = new StreamReader(filePath))
{
    json = sr.ReadToEnd();
    Console.WriteLine(json);
}

List<Student> studentsDeserialized = JsonConvert.DeserializeObject<List<Student>>(json);

using (StreamReader sr = new StreamReader(oneObjectFilePath))
{
    json = sr.ReadToEnd();
    Console.WriteLine(json);
}

Student oneStudentDeserialized = JsonConvert.DeserializeObject<Student>(json);
