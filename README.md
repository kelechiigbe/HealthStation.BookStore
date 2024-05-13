# HealthStation.BookStore

  ## To clone the repository and run the .NET Core 8 Web API, follow these steps:

   - Clone the repository using Git:
     ### git clone https://github.com/kelechiigbe/HealthStation.BookStore.git

   - Navigate to the project directory:
     ### cd HealthStation.BookStore

   - Update the appsettings.json file with your MySQL connection string.

   - Restore dependencies and build the project by runing:
     ### dotnet resore 
     ### dotnet build

   - Apply EF Core migrations to create the database:
     ### dotnet ef database update

   - Run the application:
     ### dotnet run


  ## Technologies used and design decisions
   - I made use of clean architecture as it helps in reducing coupling between components, making the codebase more flexible and resilient to   changes. It also enables better code organization, leading to improved code quality and easier debugging. Overall, clean architecture enhances the long-term sustainability and evolution of software projects by providing a solid foundation for growth and adaptation to future requirements.

   - I made use of FluentValiadions api so as to separate validation concerns from my business logic, promoting a cleaner and more organized codebase.

   - I made use of MYSQL and using AddDbContextPool for MySQL as it offers significant benefits in terms of performance and resource management. This method is particularly useful when dealing with multiple concurrent requests to the database. By using AddDbContextPool, I can efficiently manage a pool of database contexts, allowing for better utilization of resources and improved response times.

   - For my data access, I made use of Entity Framework Core for the following reasons 1. Productivity 2. Cross-Platform Support 3. LINQ Integration 4. Migration Support 5. Performance Optimization: Entity Framework Core includes features like query caching and lazy loading, which can help optimize performance.

  ## Testing
   - You can test this app from Visual Studion from this file: HealthStation.BookStore.Api.http, which is the project directory
   - After running the application you can navigate to [BaseUrl/swagger/index.html] to test the endpoints.
   - You can import the api collection from https://api.postman.com/collections/8904366-ce7b076f-b8d7-49aa-b81d-c36cdd168f86?access_key=PMAT-01HXRQ4EMCBN7EBQ7KFN962NGN if you have Postman install. 

 ## Note:
  - if I have some seed data on infractructure layer on the Data folder targeting only development environment. You can make use of for testing.
 





