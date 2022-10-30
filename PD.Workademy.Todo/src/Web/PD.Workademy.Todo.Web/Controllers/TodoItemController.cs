using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Web.ApiModels;
using System;
using System.Collections.Generic;

namespace PD.Workademy.Todo.Web.Controllers
{
    
    [ApiController]

    //GET TODO ITEM
    public class TodoItemController : ApiBaseController
    {
        //GET
        [HttpGet]
        public async Task<ActionResult> GetTodoItem(Guid Id)
        {
            TodoItemDTO todoitem =
                new TodoItemDTO (
                    Id, "Make Database", "In this task you should make database for our application in SQL", false,
                    new CategoryDTO( new Guid("5bb7b8f2-3c94-4228-b460-5e57b8342c25"), "Easy"),
                    new UserDTO( new Guid("9e73d18d-9dd8-4fd8-984e-7fb41ccfab7b"), "Nikola", "Nikolic"
                    )
                );
            return Ok(todoitem);
        }


        //ADD TODO ITEM
        [HttpPost]
        public async Task<ActionResult> AddTodoItem([FromBody] TodoItemDTO newTodoItem)
        {
            List<TodoItemDTO> TodoItems =
                new List<TodoItemDTO>()
                {
                        new TodoItemDTO(
                                            new Guid("4987aaf4-e692-4681-bb97-fcfa0d928258"),"Make API","You should create backend api-s",false,
                                            new CategoryDTO(new Guid("41f281ad-c017-4564-8945-4f1ef3e42da1"), "Medium"),
                                            new UserDTO(new Guid("66a7661a-aa07-4188-b0bc-933f43c1881e"),"Aleksandar","Vidakovic")
                                        ),
                        new TodoItemDTO(
                                            new Guid("7e18befc-b9bb-4526-807a-36bd3ebbf1d5"),"Design Frontend","You should make design for application",false,
                                            new CategoryDTO(new Guid("5f9c2643-735b-4a3d-8f9a-0c810c5069c3"), "Medium"),
                                            new UserDTO(new Guid("ff5967a3-3138-4c52-8f87-4aaa73228f37"),"Slavica","Slavic")
                                        ),
                        new TodoItemDTO(
                                            new Guid("2ff2a1a9-c704-469a-a21a-a3df7f357dbb"),"Push app to the cloud ","You should push our app to the azure platform",false,
                                            new CategoryDTO(new Guid("f7d03bc0-4121-490b-a82b-8f09ee81d1c4"), "Hard"),
                                            new UserDTO(new Guid("1fc0fac6-77f0-4f5f-be57-e183897369c2"),"Ognjen","Ognjenovic")
                                        ),
                };
            TodoItems.Add(newTodoItem);
            return Ok(TodoItems);
        }

        //DELETE
        [HttpDelete]
        public async Task<ActionResult> DeleteTodoItem(Guid Id)
        {
               List<TodoItemDTO> TodoItems =
               new List<TodoItemDTO>()
                {
                        new TodoItemDTO(
                                            new Guid("4987aaf4-e692-4681-bb97-fcfa0d928258"),"Make API","You should create backend api-s",false,
                                            new CategoryDTO(new Guid("41f281ad-c017-4564-8945-4f1ef3e42da1"), "Medium"),
                                            new UserDTO(new Guid("66a7661a-aa07-4188-b0bc-933f43c1881e"),"Aleksandar","Vidakovic")
                                        ),
                        new TodoItemDTO(
                                            new Guid("7e18befc-b9bb-4526-807a-36bd3ebbf1d5"),"Design Frontend","You should make design for application",false,
                                            new CategoryDTO(new Guid("5f9c2643-735b-4a3d-8f9a-0c810c5069c3"), "Medium"),
                                            new UserDTO(new Guid("ff5967a3-3138-4c52-8f87-4aaa73228f37"),"Slavica","Slavic")
                                        ),
                        new TodoItemDTO(
                                            new Guid("2ff2a1a9-c704-469a-a21a-a3df7f357dbb"),"Push app to the cloud ","You should push our app to the azure platform",false,
                                            new CategoryDTO(new Guid("f7d03bc0-4121-490b-a82b-8f09ee81d1c4"), "Hard"),
                                            new UserDTO(new Guid("1fc0fac6-77f0-4f5f-be57-e183897369c2"),"Ognjen","Ognjenovic")
                                        ),
                };
            TodoItemDTO TodoItemToDelete = TodoItems.Find(x => x.Id == Id);
            TodoItems.Remove(TodoItemToDelete);
            return Ok(TodoItems);
        }

        //UPDATE
        [HttpPut]
        public async Task<ActionResult> UpdateTodoItem(Guid Id, TodoItemDTO newTodoItem)
        {
            List<TodoItemDTO> TodoItems =
               new List<TodoItemDTO>()
                {
                        new TodoItemDTO(
                                            new Guid("4987aaf4-e692-4681-bb97-fcfa0d928258"),"Make API","You should create backend api-s",false,
                                            new CategoryDTO(new Guid("41f281ad-c017-4564-8945-4f1ef3e42da1"), "Medium"),
                                            new UserDTO(new Guid("66a7661a-aa07-4188-b0bc-933f43c1881e"),"Aleksandar","Vidakovic")
                                        ),
                        new TodoItemDTO(
                                            new Guid("7e18befc-b9bb-4526-807a-36bd3ebbf1d5"),"Design Frontend","You should make design for application",false,
                                            new CategoryDTO(new Guid("5f9c2643-735b-4a3d-8f9a-0c810c5069c3"), "Medium"),
                                            new UserDTO(new Guid("ff5967a3-3138-4c52-8f87-4aaa73228f37"),"Slavica","Slavic")
                                        ),
                        new TodoItemDTO(
                                            new Guid("2ff2a1a9-c704-469a-a21a-a3df7f357dbb"),"Push app to the cloud ","You should push our app to the azure platform",false,
                                            new CategoryDTO(new Guid("f7d03bc0-4121-490b-a82b-8f09ee81d1c4"), "Hard"),
                                            new UserDTO(new Guid("1fc0fac6-77f0-4f5f-be57-e183897369c2"),"Ognjen","Ognjenovic")
                                        ),
                };
            TodoItemDTO oldtodoItem = TodoItems.Find(x => x.Id == Id);
            oldtodoItem.Id = newTodoItem.Id;
            oldtodoItem.Title = newTodoItem.Title;
            oldtodoItem.Description = newTodoItem.Description;
            oldtodoItem.Category = newTodoItem.Category;
            oldtodoItem.User = newTodoItem.User;
            return Ok(newTodoItem);
        }






    }
}
