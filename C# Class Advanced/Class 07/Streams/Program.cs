string currentDirectory = Directory.GetCurrentDirectory();
string folderName = $@"{currentDirectory}\MyNewDirectory";

if (!Directory.Exists(folderName))
{
    Directory.CreateDirectory(folderName);
}

string fileName = $@"{currentDirectory}\users.txt";

using (StreamWriter sw = new StreamWriter(fileName))
{
    sw.WriteLine("Zdravo na site");
    sw.WriteLine("Zdravo na site ushte ednash");
    sw.WriteLine("I PAK ZDRAVO");
    sw.Flush();
    sw.Close();
}

using (StreamReader sr = new StreamReader(fileName))
{
    string allContent = sr.ReadToEnd();
    Console.WriteLine(allContent);
    sr.Close();
}