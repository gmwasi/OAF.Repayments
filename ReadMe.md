#Migrations

Create a database on mysql

update your connection info on the app.config

Navigate to the web project folder on cmd/terminal and run
- dotnet ef database update

To clear the database
- dotnet ef database -f

To add a migration
- dotnet ef migrations add <Migration name>