# _Doug's Animal Shelter_

#### _An app for Doug's Animal Shelter to display the animals there, Latest update 06/12/2020_

#### By _**Mai C.**_



## Description

_This app was designed for Doug's Animal Shelter, to help patrons find out what animals are availble to adopt. This Animal shelter currently has cats and dogs for adoption._

## Project Specifications

| Behavior | Input | Output |
|---|---|---|
|user is able to see animals available |click get, enter fields or leave blank|list of animals meeting search field gets brought up, or all animals if fields left blank |
|user is able to add an animal|click post and fill out fields|a new animal is created and added to list|
|a user is able to look up a specific animal using id|The user clicks the get button with id field, enter id of specific animal|the animals information is then displayed in swagger|
|a user is able to edit an existing animal|click put and then enter new info into fields|specific animal is now updated with new info|
|a user is able to delete a specific animal|click delete then enter animalid|refresh get for list of animals, and they should be removed|


## Setup/Installation Requirements

_In Terminal:_

* Navigate to https://github.com/LonleyBuzzyBee/AnimalShelter in browser.
* Click green "Clone or Download" button in github.
* Copy https://github.com/LonleyBuzzyBee/AnimalShelter.git.
* Paste link into terminal, do command "git clone [link]".
* Navigate to folder called "AnimalShelter".
* Do command "dotnet restore" in terminal.
* Then command "dotnet watch run" in terminal.
* Live server will then run live app in you browser, enjoy.

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/LonleyBuzzyBee/AnimalShelter/issues) here on GitHub._

## Technologies Used

* _C#_
* _Asp.Net Core 2.2 WebApi_
* _Entity_

## Referenced these sites

* _used to set up swagger_
https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-3.1

* _used to set up pagination_
https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/sorting-filtering-and-paging-with-the-entity-framework-in-an-asp-net-mvc-application

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Mai C._**