# BookStore App
   - This is a part of a feature application that allows a user to achieve the following scenario:
     1. User should be able to delete list of books by book ids
     2. User should be able to view how much revenue generated over a given period
     3. User should be able to view the top 10 highest selling authors
        
  ## To clone the repository and run the .NET 8 App, follow these steps:
  
   - Clone the repository using Git:
     ### git clone https://github.com/kelechiigbe/HealthStation.BookStore.git

   - Navigate to the project directory:
     ### cd HealthStation.BookStore

   - Update the appsettings.json file with your MySQL connection string.

   - Restore dependencies and build the project by runing:
     ### dotnet restore 
     ### dotnet build

   - Apply EF Core migrations to create the database:
     ### dotnet ef database update

   - Run the application:
     ### dotnet run


  ## Technologies used and design decisions
   - I made use of clean architecture as it helps in reducing coupling between components, making the codebase more flexible and resilient to   changes. It also enables better code organization, leading to improved code quality and easier debugging. Overall, clean architecture enhances the long-term sustainability and evolution of software projects by providing a solid foundation for growth and adaptation to future requirements.

   - I made use of FluentValiadions api so as to separate validation concerns from my business logic, promoting a cleaner and more organized codebase.

   - I made use of MYSQL and using AddDbContextPool for MySQL as it offers significant benefits in terms of performance and resource management. This method is particularly useful when dealing with multiple concurrent requests to the database. By using AddDbContextPool, I can efficiently manage a pool of database contexts, allowing for better utilization of resources and improved response times.

   - For my data access, I made use of Entity Framework Core for the following reasons
     1. Productivity
     2. Cross-Platform Support
     3. LINQ Integration
     4. Migration Support
     5. Performance Optimization: Entity Framework Core includes features like query caching and lazy loading, which can help optimize performance.

  ## Testing
   - You can test this app from Visual Studio from this file: HealthStation.BookStore.Api.http, which is in the project directory
   - After running the application you can navigate to [BaseUrl/swagger/index.html] to test the endpoints.

 ## Note:
  - I have some seed data on infractructure layer on the Data folder targeting only development environment. You can make use of it for testing.
  - You can download MySQL Community Edition from here https://dev.mysql.com/downloads/workbench/. This is soley for testing purpose.

I hope you enjoy reading the source code as I enjoyed coding it. 
 





