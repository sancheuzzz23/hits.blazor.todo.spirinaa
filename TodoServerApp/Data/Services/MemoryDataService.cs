﻿using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataservice
    {
        private static IEnumerable<TaskItem> tasks { get; } = [
        
            new() { Id = 1, Title = "Задача 1", Description  = "Описание задачи 1", CreatedDate = DateTime.Now },
            new() { Id = 1, Title = "Задача 2", Description  = "Описание задачи 2", CreatedDate = DateTime.Now },
            new() { Id = 1, Title = "Задача 3", Description  = "Описание задачи 3", CreatedDate = DateTime.Now },
        ];
        public async Task<IEnumerable<TaskItem>> GetTaskItemAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(tasks);
        }
    }
}
