# MVC .NET Core RESTful API with Swagger Documentation

## Description

This is a custom built MVC .NET Core RESTful API to manage, and display restaurants and shops in the database. You can do all CRUD functionality including create, update, delete, get one, get all, for both restaurants and shops.

By Austin Schrader, 1/22/2020

## .NET Core 2.2 Installation

- [Download .NET Core 2.2 for Windows here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer)
- [Download .NET Core 2.2 for MacOS here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer)

## MySQL & MySQL Workbench Installation

- [Download MySQL & MySQL Workbench for Windows here](https://dev.mysql.com/downloads/file/?id=484914)
- [Download MySQL & MySQL Workbench for MacOS here](https://dev.mysql.com/downloads/file/?id=484919)

## API Project Setup

1. Clone or Download this repository
2. Navigate to the folder where you downloaded or cloned this repository
3. Now open your terminal and navigate to friday-business-api > BusinessApi
4. Type in `dotnet restore` to download necessary packages
5. Modify the file titled appsettings.json and input your MySQL password as the value for "pwd"
6. Import the MySQL database
7. Then type in `dotnet run` to run the application
8. Congratulations, this is the program!

# API Documentation

## Swagger Setup

- Swagger documentation is a fantastic tool that allows you to generate API documentation.
- To access Swagger, you actually don't need to do any additional setup or installation.

1. Immediately after finishing "Project Setup" instructions, when the application is running, navigate to http://localhost:5000/swagger/index.html
2. You can click on either "Shops" or "Restaurants" to be shown the CRUD routes that the API supports.
3. To add a Shop, click the Shops button
4. Then click POST for /api/Shops
5. Finally all Shops, click on the "Get" button and then

## API Documentation

### API Endpoints

Home URL of the API: http:localhost:5000/

The structure of the API requests are as follows:
![Routes for API](https://github.com/austinschrader/friday-business-api/blob/main/README%20files/routes.PNG)

### API Example Queries for Restaurants

| Purpose             | URL                                        | Method | Body                                                                                                              | Return Value                                                                                                                           |
| ------------------- | ------------------------------------------ | ------ | ----------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- |
| Get all Restaurants | http://localhost:5000/api/restaurants      | GET    | -                                                                                                                 | ![GET all Restaurants Return Value](https://github.com/austinschrader/friday-business-api/blob/main/README%20files/getrestaurants.PNG) |
| Post a Restaurant   | http://localhost:5000/api/restaurants      | POST   | ![POST Body Example](https://github.com/austinschrader/friday-business-api/blob/main/README%20files/postbody.PNG) | ![POST a Restaurant Return Value](https://github.com/austinschrader/friday-business-api/blob/main/README%20files/getrestaurants.PNG)   |
| Get a Restaurant    | http://localhost:5000/api/restaurants/{id} | GET    | -                                                                                                                 | ![GET a Restaurant Return Value](https://github.com/austinschrader/friday-business-api/blob/main/README%20files/getrestaurants.PNG)    |
| Put a Restaurant    | http://localhost:5000/api/restaurants/{id} | PUT    | ![PUT Body Example](https://github.com/austinschrader/friday-business-api/blob/main/README%20files/putbody.PNG)   | ![PUT a Restaurant Return Value](https://github.com/austinschrader/friday-business-api/blob/main/README%20files/getrestaurants.PNG)    |
| Delete a Restaurant | http://localhost:5000/api/restaurants/{id} | DELETE | -                                                                                                                 | ![DELETE a Restaurant Return Value](https://github.com/austinschrader/friday-business-api/blob/main/README%20files/getrestaurants.PNG) |

## Import MySQL database

1. Open MySQL Workbench & enter in your MySQL password
2. Navigate to Administration
3. Click Data Import/Restore
4. Click the 'Import from Self-Contained File' radio button
5. Click the `...` button and navigate to the Downloaded/Cloned repository and double click on the SQL database
6. Select Dump Data & Structure
7. Start Import

## How to Setup MySQL Database Using Entity Framework

1. Navigate to the project directory, in this case Shop.Solution > Shop
2. Run `dotnet ef database update` to generate the MySQL Database using the migration
3. If you want to update the structure of the DB, first modify the models, then run: `dotnet ef migrations add {MIGRATIONNAMEHERE}`
4. Finally, run the `dotnet ef database update` to apply the migration to your MySQL database

## Clone this repository

1. Download this repository by clicking the "Code" button and then copy the url
2. Open a terminal and navigate to where you want the repository cloned to
3. Type in `git clone https://github.com/austinschrader/friday-business-api`
4. Congratulations, you cloned the repository.

## Download this repository

1. Download this repository by clicking the "Code" button and then "Download Zip"
2. Right click the downloaded file and "Unzip"
3. Double click on the file that was just unzipped
4. Congratulations, you downloaded the repository.

## Known Bugs

At this time, there are no known bugs. If you see spot a bug feel free to make a pull request.

## Technologies Used

- C#
- .NET Core 2.2
- MySQL & MySQL Workbench
- Object Oriented Programming
- Entity Framework
- Git
- Gitbash
- Github
- Identity
- Swagger Documentation
- API
- NSwag
- Postman

## License

This repository is licensed under the MIT license.

Copyright (c) 2020 by _Austin Schrader_
