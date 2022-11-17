namespace PD.Workademy.Todo.Application.ApiModels
{
    public class TodoItemSeparateDTO
    {
        public int Page { get; set; }
        public int PerPage { get; set; }

        public string? Search { get; set; }
        public string? SortBy { get; set; }

        public TodoItemSeparateDTO()
        {

        }

        public TodoItemSeparateDTO(int Page, int PerPage, string Search, string sortBy)
        {
            Page = Page;
            PerPage = PerPage;
            Search = Search;
            SortBy = SortBy;
        }



    }
}
