# Project: MinhaBiliotecaVirtual (My Virtual Library)

 
<p align="center">
  <img  src="https://github.com/denissongomes/MinhaBiliotecaVirtual/blob//master/Recursos/splash.png?raw=true">
</p>

"The MinhaBiliotecaVirtual (My Virtual Library) project is integrated into the Visual Programming class of the Systems Analysis and Development program at the International University Center Uninter."

## Briefing

Develop a desktop application using Windows Forms in C# within the Visual Studio .NET Framework development environment. The project should include interfaces for registering, consulting, and deleting records from a database, with access restricted to authorized users.

## Project Creation:
- Create a new Windows Forms Application project using .NET Framework in Visual Studio.
- Use the C# programming language.

## Database:
- Design and implement a database to store records.
- You can use the suggested database model attached to this specification.
- Use a relational database such as MySQL.
  
## User Interfaces:
- Create interfaces for the operations of registering, consulting, and deleting records.
- The interfaces should be user-friendly and intuitive.
- Use at least one ComboBox in one of the interfaces.
- Configure the properties of the fields according to class standards and best programming practices.

## Fucnctionalities
- Record Inclusion: Interface for inserting new records into the database.
- Record Query: Interface for searching and viewing existing records.
- Record Deletion: Interface for removing records from the database.

## Authentication
- Implement a login functionality to restrict access to authorized users only.
- You can create a table in the database with records of authorized users. While adding, modifying, and deleting users is not required, you will need to create a query in the user table to validate if the user exists and if the entered password matches the registered password.
