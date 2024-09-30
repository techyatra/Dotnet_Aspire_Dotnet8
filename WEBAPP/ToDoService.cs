namespace WEBAPP
{
    public class ToDoService
    {

        private readonly HttpClient _httpClient;
        public ToDoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        

        public async Task<List<string>> GetToDosAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<string>>("api/todo");
        }

        public async Task PostAsync(string todo)
        {
            await _httpClient.PostAsJsonAsync("api/todo", todo);
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/todo/{id}");
        }
    }
}
