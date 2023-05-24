# Challenge Tech Coodesh


## 🧾  About


This is a Coodesh challenge of a multi-language project developed with the objective of developing an API, and a Front-End page communicating with a relational database.The purpose of which is to upload a file via the web page, receive it via the Backend, process the data, save it in the database and return the information to the user.

## 📖 Summary
<div id='summary'></div>

>
> [1 - Chain Of Thought](#chainOfThought) 
>
> [2 - Technologies](#Technologies) 
>
> [3 - BackEnd ](#Backend) 
>
>[3.1 - API Documentation](#chainOfThought)
>
>[4 - DataBase](#chainOfThought)
>
>[5 - Front End](#chainOfThought)
>
>[6 - Docker](#chainOfThought)

<br/>

<div id="chainOfThought"></div>

#  🧠 Train of Thought

<br/>

1 - First I need to think with which languages ​​I would do each part of the project. So for the sake of having more practice I choose to make the backend in C#, which is the whole communication part with the DataBase and the API. And consequently React was left to make the web page.

2 - I decide to start the project from the backend, already creating the classes to be used as variables for manipulation and already creating the database manipulation by the entity framework.

3 - There was a difficulty in thinking about a form of relationship based on the insertion of user data. The difficulty was creating the Types(Variety in database, type is a reserved name by system) table in the database when the user insert the data, but there was no such need if I thought about it correctly, so I decided to create a standard script, where before starting any data insertion, the Database with this script.

4 - Related to the sales table (user upload), the name of the sellers that comes from another table, the table of the type that is linked and the table of products. So when the sales table is displayed, the name of the product, the name of the seller, and the type of sale are displayed.

5 - After related database and defined classes, I went to create the connection of the classes with the controllers to manipulate the api, 
testing with post if each data was being inserted, updated, deleted or displayed in the correct way. And try to apply the unit tests with NUnit or XUnit, but as my time was running out, I preferred to do the front end and as soon as I had time, I would return to do the unit tests

6 - With the node installed, and the visual code, I started the project with "npx-create-react" and started the part with the Front End. But since I'm not a person who knows a lot about Screen Design, creating incredible visual things from scratch, I only know how to run from a design made, something that came from FIGMA or something like that, so I will create a simple and functional screen.

7 - I'll start with the header, which will be shared by all screens, where there are buttons and screen directions for the respective functionalities. Then the upload screen for me to validate the upload method that would be done. And then the value display screens.

8 - For communication to work perfectly between front and back, as they are different "servers", I needed to enable CORS and allow access-control-allow-origin for my front to be able to communicate perfectly.

9 - As time was running out, I already decided to implement docker, which was by far the one that I least had the domain to run in the best way, and I already took advantage and implemented the docker-compose.

<br/>
<br/>
<br/>

## 💻 Technologies 
<div id="Technologies"></div>

<br/>
<br/>

 1 - [ C#](href='https://learn.microsoft.com/en-us/dotnet/csharp/')
 <br/>

 2 - [ SQL Server](href='https://learn.microsoft.com/pt-br/sql/?view=sql-server-ver16')
 <br/>

 3 - [React Js](href='https://legacy.reactjs.org/docs/getting-started.html')
 <br/>

4 - [docker](href='https://docs.docker.com/')
<br/>

[Return to top](#summary)

<br/>
 
 # 💻 Backend
 <div id="Backend"></div>

 <br/>
 <br/>
The entire backend part of the project was based on the .NET platform and its technologies (frameworks, C# language, etc.). And all packages used were installed directly by Nuget's package manager.
<br/>

![Gif1](/desafio/public/gifs/GIF%2024-05-2023%2014-37-08.gif "Gif-1")
<br/>
<br/>



<br/>
<br/>

## 📄 API Documentation
<br/>

To go for API Documentation click [Here!](href='link') 👈

<br/>
<br/>
<br/>

# 💾 DataBase
<div id="Database"></div>

The database is simple, but all have some kind of relationship with the main table (Sales).
The database has 3 tables with a primary key where the table is referenced in the Sales table, since it is foreign in the Sales table itself.As in the example below.

<br/>

![dataBase](/desafio/public/image/diagram.png "Diagram")

<br/>

To run the database correctly, and create it if you don't have it in your SQL Server, you need to run a simple command in the package manager as in the example below
<br/>

![Gif1](/desafio/public/gifs/GIF%2024-05-2023%2017-06-51.gif "Gif-1")

<br/>
With the package manager console open, enter the command:
<br/>
<br/>

>
> update-database

<br/>
After that, open Sql Server and open a new database query and add the "scripPadrao" located in the data folder of the backend project.
<br/>
<br/>

![locate](/desafio/public/image/Screenshot_1.png "locate")

<br/>
<br/>

Add the "scriptPadrao" in database:
<br/>
<br/>

![script](/desafio/public/gifs/GIF%2024-05-2023%2017-22-28.gif "script")

<br/>
After that the database will work correctly.

# 💻 Front-End
<br/>

After having cloned the repository to your computer, 1 command is enough for the app to work by the VsCode terminal itself
<br/>
<br/>

> npm install

<br/>

Then just type the command to start the application

<br/>

> npm start

<br/>


If the application does not work at first, it will be necessary to manually install the necessary packages;


<br/>

> npm install axios

<br/>
 And

 <br/>


> npm install react-router-dom

<br/>
After that just apply npm start again and your web page will work normally


<br/>
<br/>

# 🐋 Docker
<div id="Docker"></div>

Docker is a powerful tool that allows us to use an environment in a controlled virtual system with the appropriate specifications for that application to run smoothly or install files on your computer.
In the case of this application, we created 3 images from the dockerfile and where we will run them.
First let's start with the database.

But you need to have an operating system running for it to work, follow the steps in the link below if you don't have docker installed.

https://docs.docker.com/engine/install/ubuntu/


To run the container with the SQL Server image, follow the commands below with the guidelines

Simply run the following command line to download the Docker image for SQL Server 2019 Linux from Docker Hub (Docker image repository):

<br/>

>docker run --name sqlserver -e "ACCEPT_EULA=Y" -e
>"SA_PASSWORD=Your-Password-Here" -p 1433:1433 -d 
>mcr.microsoft.com/mssql/server:2019-CU15-ubuntu-20.04

<br/>
Set a password by changing the value of the “SA_PASSWORD” property, and don't forget that very simple passwords do not allow the process to complete successfully. Try to use symbols, numbers and letters to pass weak password validation. It is interesting to define a name for the container through the optional parameter --name

<br/>

![dataBase](/desafio/public/image/docker%20sql.png "Diagram")

>The "name" parameter is optional but it facilitates the next step.

<br/>
If everything is right, the download process will start. It is usually fast, as the version of the operating system used is always very lean, and it can even be reused offline by another image to compose a container.

<br/>

## Docker in BackEnd


As there is already a configured dockerfile, just open it through the visual code and run a build image.

<br/>

![dataBase](/desafio/public/gifs/GIF%2024-05-2023%2018-30-01.gif "Diagram")

<br/>

Just like the front end file, it also has a dockerfile file, and run it the same way.

## Docker Compose

There is a file called docker-compose.yml , this file will allow all containers to be lifted and communicating with each other, if there is no image it will download and create one.
To run just type the command below

<br/>

> docker-compose up




> Video presentation coodesh
> https://www.loom.com/embed/4808ffa0cd404ff2bc9b43bcaa81f7e7





