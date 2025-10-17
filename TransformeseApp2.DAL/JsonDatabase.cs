using System.Text.Json;

namespace TransformeseApp2.DAL
{
    public static class JsonDatabase
    {
        // Caminho da pasta onde os arquivos da pasta serão salvos
        private static readonly string DataFolder = Path.Combine(Environment.CurrentDirectory, "Data");

        // Construtor estático  - Executado uma vez quando a classe é acessada pela primeira vez
        static JsonDatabase()
        {
            // Verifica se a pasta "Data" existe, se não, cria a pasta
            if (!Directory.Exists(DataFolder))
            {
                Directory.CreateDirectory(DataFolder);
            }
        }

        // Lê uma lista de objetos do tipo T a partir de um arquivo JSON
        // Cria o arquivo vazio se ele não existir
        public static List<T> Ler<T>(string fileName) where T : class
        {
            string path = Path.Combine(DataFolder, fileName);

            // Cria o arquivo JSON vazio (Lista vazia) caso não exista
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "[]");
            }

            // Lê o conteudo do arquivo JSON
            string json = File.ReadAllText(path);

            // Desserializa para uma lista do tipo T
            // retornando uma lista vazia se for null

            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        public static void Salvar<T> (string fileName, List<T> lista) where T : class
        {
            string path = Path.Combine(DataFolder, fileName);

            // Serializa a lista para JSON com identação para melhor leitura
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(path, json);
        }
    }
}
