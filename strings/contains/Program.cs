List<string> languages = new List<string>
{
  "c#",
  "java",
  "javascript",
  "python"
};

bool languageExists = languages.Contains(languageSearch);

if (languagesExists)
{
  Console.WriteLine("Essa linguagem existe no sistema");
}
else{
  Console.WriteLine("Essa linguagem não existe no sistema");
